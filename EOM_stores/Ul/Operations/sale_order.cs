using System;
using System.Globalization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using EOM_auth;

namespace EOM_stores.Ul.Operations
{
    public partial class sale_order : Form
    {
        DataTable prodctList = new DataTable();
        _ctrlChannel _socket;

        private int _customerId; private int customerId{ get; set; }
        private int _indexer; private int indexer { get; set; }
        void prdlist()
        {
            prodctList.Columns.Add("معرف المنتج");
            prodctList.Columns.Add("اسم المنتج");
            prodctList.Columns.Add("المقاس");
            prodctList.Columns.Add("الثمن");
            prodctList.Columns.Add("الحجم");
            prodctList.Columns.Add("الكمية");
            prodctList.Columns.Add("المبلغ");
            prodctList.Columns.Add("الخصم");
            prodctList.Columns.Add("المبلغ الاجمالي");
            prodctList.Columns.Add("رقم أمر التسليم");

            dgvOrder.DataSource = prodctList;

        }

        void resizeDgv()
        {
            _customerId = customerId;
            _indexer = indexer;
            dgvOrder.RowHeadersWidth = 29;
            dgvOrder.Columns[0].Width =86;
            dgvOrder.Columns[1].Width = 129;
            dgvOrder.Columns[2].Width = 105;
            dgvOrder.Columns[3].Width = 87;
            dgvOrder.Columns[4].Width = 87;
            dgvOrder.Columns[5].Width = 87;
            dgvOrder.Columns[6].Width = 87;
            dgvOrder.Columns[7].Width = 87;
            dgvOrder.Columns[8].Width = 103;
            dgvOrder.Columns[9].Visible=false;

        }

        void orderId()
        {
            //-----------------------------------------------
            _socket = new _ctrlChannel();
            DataTable ft = new DataTable();
            ft = _socket.getTargetId("@orderId", "getOrderId");
            int indexer = ft.Rows[0].Field<int>("max(`salTrafficId`)") + 1;
            txtOrderId.Text = indexer.ToString();
            //-----------------------------------------------
        }
    public sale_order()
        {
            InitializeComponent();

            orderId();
            prdlist();
            resizeDgv();
            //empName.Text = Program._fullUsrName;
            
        }

        void calculateAmount()
        {
            if (catePrice.Text != string.Empty && cateQte.Text != String.Empty)
            {
                prdAmount.Text = (Convert.ToDouble(catePrice.Text) * Convert.ToInt32(cateQte.Text)).ToString();
            }

        }

        void calculateTotalAmount()
        {
            if (prdDiscound.Text != string.Empty && prdAmount.Text != string.Empty)
            {
                double discound = Convert.ToDouble(prdDiscound.Text);
                double Amount = Convert.ToDouble(prdAmount.Text);
                double totalAmount = Amount - (Amount * (discound / 100));
                cateTotalAmount.Text = totalAmount.ToString();
                //lastTotalAmount.Text = Convert.ToString(Convert.ToDouble(txtTotalAmount.Text) * Convert.ToInt32(prdCost.Text));

            }

        }

        void clearFields()
        {
            catId.Clear();
            cateName.Clear();
            prdSize.Clear();
            catePrice.Clear();
            cateVolum.Clear();
            cateQte.Clear();
            prdAmount.Clear();
            prdDiscound.Clear();
            cateTotalAmount.Clear();
        }
        private double Main_Accountprice;
        private void btnBrignCust_Click(object sender, EventArgs e)
        {
            Ul.customers.ivCust ivcust = new customers.ivCust();

            ivcust.ShowDialog();

            _customerId = Convert.ToInt32(ivcust.dgvIvCust.CurrentRow.Cells[0].Value.ToString());
            custName.Text = ivcust.dgvIvCust.CurrentRow.Cells[1].Value.ToString();
            phoneNo.Text = ivcust.dgvIvCust.CurrentRow.Cells[3].Value.ToString();
            custEmail.Text = ivcust.dgvIvCust.CurrentRow.Cells[4].Value.ToString();
            accNo.Text = ivcust.dgvIvCust.CurrentRow.Cells[6].Value.ToString();
            double  Accountprice = Convert.ToDouble(ivcust.dgvIvCust.CurrentRow.Cells[8].Value);
            accPrice.Text = Accountprice.ToString();
            Main_Accountprice = Accountprice;
    }

        private void piExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBringProducts_Click(object sender, EventArgs e)
        {
            Shared.ivProduct ivprd = new Shared.ivProduct();
            Shared.eeProduct eeprd = new Shared.eeProduct();
            ivprd.ShowDialog();
            //eeprd.calculateCost(Convert.ToInt32(txtPercentge.Text));
            catId.Text = ivprd.dgvIvPrd.CurrentRow.Cells[0].Value.ToString();
            cateName.Text = ivprd.dgvIvPrd.CurrentRow.Cells[1].Value.ToString();
            prdSize.Text = Convert.ToString(ivprd.dgvIvPrd.CurrentRow.Cells[2].Value.ToString()+
                " X "+ ivprd.dgvIvPrd.CurrentRow.Cells[3].Value+" X "+ ivprd.dgvIvPrd.CurrentRow.Cells[4].Value);
            // prdPrice.Text = ivprd.dgvIvPrd.CurrentRow.Cells[13].Value.ToString();
            //prdPrice.Text=Convert.ToString(Convert.ToDouble(ivprd.dgvIvPrd.CurrentRow.Cells[13].Value) * Convert.ToInt32(txtPercentge.Text) / 100);
            try
            {
                if(Convert.ToInt32(ivprd.dgvIvPrd.CurrentRow.Cells[5].Value)!=0)
                {
                    //cateVolum.Text = ivprd.dgvIvPrd.CurrentRow.Cells[5].Value.ToString();
                    volumLbl.Text = "الحجم";
                }
                else
                {
                    //cateVolum.Text = ivprd.dgvIvPrd.CurrentRow.Cells[6].Value.ToString();
                    volumLbl.Text = "الوزن";
                }
                catePrice.Text = Convert.ToString(ivprd.dgvIvPrd.CurrentRow.Cells[8].Value);
                catePrice.Focus();
                /*if(Convert.ToInt32(txtPercentge.Text)!=0)
                {
                    catePrice.Text = Convert.ToString(Math.Round(Convert.ToDouble(ivprd.dgvIvPrd.CurrentRow.Cells[13].Value) +
                    (Convert.ToDouble(ivprd.dgvIvPrd.CurrentRow.Cells[13].Value) * Convert.ToInt32(txtPercentge.Text) / 100)));
                    cateQte.Focus();
                /*}
                else
                {
                    MessageBox.Show("يجب ألا تكون النسبة المئوية تساوي صفر!!","إخطار",MessageBoxButtons.OK,MessageBoxIcon.Warning); txtPercentge.Focus();
                }
                */

            }
            catch (InvalidCastException fX) { }
            


        }

        private void btnReject_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void prdQte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void prdPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(CultureInfo.CurrentUICulture.NumberFormat.CurrencyDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void prdQte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && cateQte.Text != "")
            {
                prdDiscound.Focus();
                //accPrice.Text = Convert.ToString(Convert.ToDouble(accPrice.Text)-Convert.ToDouble(prdPrice.Text)* Convert.ToDouble(prdQte.Text));
            }
        }

        private void prdPrice_KeyUp(object sender, KeyEventArgs e)
        {
            calculateAmount();
            calculateTotalAmount();
        }

        private void prdQte_KeyUp(object sender, KeyEventArgs e)
        {
            calculateAmount();
            calculateTotalAmount();
        }

        private void prdDiscound_KeyUp(object sender, KeyEventArgs e)
        {
            calculateTotalAmount();
        }

        private int lastOrder;

        private void prdDiscound_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                DataRow ro = prodctList.NewRow();
                
                ro[0] = catId.Text;
                ro[1] = cateName.Text;
                ro[2] = prdSize.Text;
                ro[3] = catePrice.Text;
                ro[4] = cateVolum.Text;
                ro[5] = cateQte.Text;
                ro[6] = prdAmount.Text;
                ro[7] = prdDiscound.Text;
                ro[8] = cateTotalAmount.Text;
                ro[9] = txtOrderId.Text;
                lastOrder = Convert.ToInt32(txtOrderId.Text);
                prodctList.Rows.Add(ro);
                dgvOrder.DataSource = prodctList;
                dgvOrder.Columns[9].Visible = false;

                //update the textbox price with new value before clearing feilds 
                /*accPrice.Text =
                    Convert.ToString(Convert.ToDouble(accPrice.Text) - Convert.ToDouble(cateTotalAmount.Text));
                    */
                clearFields();

                txtTotalAmount.Text =
                    (from DataGridViewRow drv in dgvOrder.Rows
                     where drv.Cells[8].FormattedValue.ToString() != string.Empty
                     select Convert.ToDouble(drv.Cells[8].FormattedValue)).Sum().ToString();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                _contr.Saling._orders ord = new _contr.Saling._orders();
                customers.ivCust ivcust = new customers.ivCust();
                if(custName.Text=="" && phoneNo.Text=="")
                {
                    MessageBox.Show("رجاءً قم بإختيار العميل لإتمام العملية..");
                    return;
                }
                else
                {
                    if (Main_Accountprice < Convert.ToDouble(txtTotalAmount.Text))
                    {
                        MessageBox.Show("هذا الحساب لا يحتوي على المبلغ الكافي لإنجاح العملية ");
                        return;
                    }
                    else
                    {
                        //insert new order  
                        ord.insOrder(Convert.ToInt32(_customerId), txtDetails.Text);
                        foreach (DataGridViewRow curRow in dgvOrder.Rows)
                        {
                            // insert new order details 
                            //orderId();

                            ord.insOrder_details(Convert.ToInt32(curRow.Cells[0].Value),
                            Convert.ToInt32(curRow.Cells[5].Value), Convert.ToInt32(prdCost.Text), Convert.ToDouble(curRow.Cells[3].Value),
                            Convert.ToDouble(curRow.Cells[6].Value), Convert.ToDouble(curRow.Cells[8].Value),
                            Convert.ToInt32(curRow.Cells[7].Value), Convert.ToDouble(curRow.Cells[4].Value), Convert.ToInt32(curRow.Cells[9].Value));



                        }
                        //prodctList.Clear();
                        if (MessageBox.Show("تمت اضافة امر تسليم بنجاح \n هل تريد طباعة إذن تسليم بضائع ؟؟ ", "اخطار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            printOrder();    
                        }
                        else
                        {
                            Close();
                        }
                    }

                }

        }

        private void prdDiscound_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
                
            }
            
        }

        private void cateVolum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && cateVolum.Text != "")
            {
                cateQte.Focus();
             
            }
        }

        private void cateVolum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printOrder();
        }

        public void printOrder()
        {
            Shared.inputBox ib = new Shared.inputBox();
            ib.TopMost = true;
            ib.ShowDialog();
            string comName = ib.companyName.Text;
            string recName = ib.reciptName.Text;



            _contr.Saling.get_Orders gOrders = new _contr.Saling.get_Orders();


            Rpt.saleOrder orderReport = new Rpt.saleOrder();
            Rpt.rptContainer reportCont = new Rpt.rptContainer();

            orderReport.SetDataSource(gOrders.getOrderDetails4Print(lastOrder, comName, recName));

            reportCont.reportViewer.ReportSource = orderReport;
            reportCont.Show();
            reportCont.Location = new Point(20, 50);
        }

        private void catePrice_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter && catePrice.Text !="")
            {
                cateVolum.Focus();
            }
        }

        private void prdCost_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                lastTotalAmount.Text = Convert.ToString(Convert.ToDouble(txtTotalAmount.Text) *
                    Convert.ToDouble(prdCost.Text));
            }
        }
    }
}
