using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using EOM_auth;

namespace EOM_stores.Ul.Operations
{
    public partial class recive_order : Form
    {
        _ctrlChannel _socket;
        DataTable catlis = new DataTable();

        public int _impNumber;
        public int _catNumber;
        double totalAmount;

        public int _rc_orderId;

        public int rc_orderId { get; set; }
        public int impNom { get; set; }
        public int catNom { get; set; }

        private void prep()
        {
            _impNumber = impNom;
            _catNumber = catNom;
            _rc_orderId = rc_orderId;
        }

        void reciveOrderId()
        {
            _socket = new _ctrlChannel();
            //-----------------------------------------------

            DataTable ft = new DataTable();
            ft = _socket.getTargetId("@reciveOrderId", "getLastRCO");
            rcONo.Text = Convert.ToString(ft.Rows[0].Field<int>("max(purTrafficNo)") + 1);
            //-----------------------------------------------
        }
        public recive_order()
        {
            InitializeComponent();
            reciveOrderId();
            //btnRecPrint.Enabled = false;
            catList();
            dgvPursh.Columns[6].Visible = false;
        }

        private void piExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBringImp_Click(object sender, EventArgs e)
        {
            Imports.ivImpo iv = new Imports.ivImpo();
            _contr.accounts._getAccs gacc = new _contr.accounts._getAccs();
            iv.ShowDialog();
            iv.Location = new Point(300, 300);
            _impNumber = Convert.ToInt32(iv.dgvIvImp.CurrentRow.Cells[0].Value.ToString());
            iFName.Text = iv.dgvIvImp.CurrentRow.Cells[1].Value.ToString();
            iPhone.Text = iv.dgvIvImp.CurrentRow.Cells[2].Value.ToString();
            iEmail.Text = iv.dgvIvImp.CurrentRow.Cells[3].Value.ToString();
            /*
            if (iv.dgvIvImp.CurrentRow.Cells[4].Value is DBNull )
            {
                // no account panel visible
                //MessageBox.Show("هذا المورد غير مرتبط بأي حساب");
                accPrice.Multiline = true;
                accPrice.Location = new Point(7, 22);
                accPrice.Size = new Size(833, 41);
                accPrice.Text = "---------------------------------------- هذا المورد غير مرتبط بأي حساب ----------------------------------------";
                
                accPrice.FontSize = MetroFramework.MetroTextBoxSize.Tall;
                
            }
            else
            {
                DataTable ct = new DataTable();
                ct = gacc.accs4Edit(Convert.ToInt32(iv.dgvIvImp.CurrentRow.Cells[4].Value.ToString()));
                accNo.Text = iv.dgvIvImp.CurrentRow.Cells[4].Value.ToString();
                accType.Text = ct.Rows[0].Field<string>("direction");
                accH2Pay.Text = ct.Rows[0].Field<string>("Htype_lable");
                accPrice.Multiline = false;
                accPrice.Size = new Size(105, 25);
                accPrice.Location = new Point(8, 25);
                accPrice.FontSize = MetroFramework.MetroTextBoxSize.Medium;
                accPrice.Text = Convert.ToString(ct.Rows[0].Field<double>("price"));

            }

            */
        }

        private void btnBringCat_Click(object sender, EventArgs e)
        {
            Categories.ivCat ivc = new Categories.ivCat();
            ivc.ShowDialog();
            if (ivc.dgvIvCat.CurrentRow.Cells[1].Value.ToString()=="خشب")
            {
                qteLabel.Text = "الكمية(سم3)";
                priceLabel.Text = "السعر(سم3)";
               
            }
            else if(ivc.dgvIvCat.CurrentRow.Cells[1].Value.ToString() == "صرة")
            {
                qteLabel.Text = "العدد";
                priceLabel.Text = "سعر الحبة";
                
            }
            else if (ivc.dgvIvCat.CurrentRow.Cells[1].Value.ToString() == "صامولة")
            {
                qteLabel.Text = "الوزن(كيلو جرام)";
                priceLabel.Text = "سعر الكيلوجرام";
            }
            else 
            {
                qteLabel.Text = "الوزن";
                priceLabel.Text = "سعر الكيلوجرام";
            }


            _catNumber = Convert.ToInt32(ivc.dgvIvCat.CurrentRow.Cells[0].Value.ToString());
            catName.Text = ivc.dgvIvCat.CurrentRow.Cells[1].Value.ToString();
            catDimentions.Text = ivc.dgvIvCat.CurrentRow.Cells[2].Value.ToString();
            catThick.Text = ivc.dgvIvCat.CurrentRow.Cells[3].Value.ToString();
            ivc.Location = new Point(300, 300);

        }


        void Clear(int _f)
        {
            if(_f==0)
            {
                catName.Clear();
                catDimentions.Clear();
                catThick.Clear();
                catQte.Clear();
                catUPrice.Clear();
                iFName.Clear();
                iPhone.Clear();
                iEmail.Clear();
                txtDetails.Clear();
            }
            else if(_f==1)
            {
                catName.Clear();
                catDimentions.Clear();
                catThick.Clear();
                catQte.Clear();
                catUPrice.Clear();
            }
            
            

        }
        void catList()
        {
            catlis.Columns.Add("معرف الصنف");
            catlis.Columns.Add("اسم الصنف");
            catlis.Columns.Add("الابعاد");
            catlis.Columns.Add("السمك");
            catlis.Columns.Add("الحجم");
            catlis.Columns.Add("الكمية");
            catlis.Columns.Add("السعر");
            catlis.Columns.Add("معرف المورد");
            catlis.Columns.Add("اسم المورد");
            catlis.Columns.Add("المبلغ الاجمالي");
            dgvPursh.DataSource = catlis;
            //Clear();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            DataRow dr = catlis.NewRow();
            
            dr[0] = _catNumber;
            dr[1] = catName.Text;
            dr[2] = catDimentions.Text;
            dr[3] = catThick.Text;
            dr[4] = categVolum.Text;
            dr[5] = catQte.Text;
            dr[6] = catUPrice.Text;
            dr[7] = _impNumber;
            dr[8] = iFName.Text;
            

            if(catQte.Text!=""&&catUPrice.Text!=string.Empty)
            {
                totalAmount = Convert.ToDouble(catUPrice.Text) * Convert.ToInt32(catQte.Text);
                dr[9] = totalAmount;
            }
            else
            {
                MessageBox.Show("رجاءً قم بإدخال الكمية و سعر الوحدة لحساب المبلغ الاجمالي");
                return;
            }
            

            catlis.Rows.Add(dr);
            Clear(1);

            txtTotal.Text =
                (from DataGridViewRow row in dgvPursh.Rows
                 where row.Cells[9].FormattedValue.ToString()
                 != string.Empty
                 select Convert.ToDouble(row.Cells[9].FormattedValue)).Sum().ToString();
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            _contr.Shared.defineSection ds = new _contr.Shared.defineSection();
            ds.getSection("addCategory");
            Close();
        }

        private void btnAddImp_Click(object sender, EventArgs e)
        {
            _contr.Shared.defineSection d = new _contr.Shared.defineSection();
            d.getSection("addImporter");
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

           
                _contr.Purshasing._pursh pur = new _contr.Purshasing._pursh();

                // add purchasing details to database

                pur.savePurshase(txtDetails.Text,_impNumber, Program._fullUsrName);

              
                // add categories in datagride view to database
                foreach(DataGridViewRow thisRow in dgvPursh.Rows)
                {
                pur.savePurshDetails(Convert.ToInt32(rcONo.Text), Convert.ToInt32(thisRow.Cells[0].Value.ToString()),Convert.ToDouble(thisRow.Cells[4].Value.ToString()),
                Convert.ToDouble(thisRow.Cells[6].Value.ToString()), Convert.ToInt32(thisRow.Cells[5].Value.ToString()));
                homeScreen hs = new homeScreen();
                hs.warningPanel();
                

            }

            MessageBox.Show("تم اضافة العملية بنجاح ...");
            btnRecPrint.Enabled = true;
                catlis.Clear();
                Clear(0);

            }

        private void btnRecPrint_Click(object sender, EventArgs e)
        {
            /* Shared.inputBox ib = new Shared.inputBox();
            ib.TopMost = true;
            ib.ShowDialog();
             double inputValue = Convert.ToDouble(ib.inputText.Text);
             */
            _socket = new _ctrlChannel();
            DataTable ft = new DataTable();
            ft = _socket.getTargetId("@reciveOrderId", "getLastRCO");
            int LastReciveRecipt = ft.Rows[0].Field<int>("max(purTrafficNo)");
            _contr.Purshasing.getPurchase gpurch= new _contr.Purshasing.getPurchase();
           
           
            Rpt.reciveOrder puReport = new Rpt.reciveOrder();
            Rpt.rptContainer reportCont = new Rpt.rptContainer();
           
            puReport.SetDataSource(gpurch.perchasePrinting(LastReciveRecipt));
           
            reportCont.reportViewer.ReportSource = puReport;
            reportCont.Show();
            reportCont.Location = new Point(20, 50); 

        }

       
    }
}

