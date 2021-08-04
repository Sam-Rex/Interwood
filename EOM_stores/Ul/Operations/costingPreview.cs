using System;
using System.Data;
using System.Windows.Forms;
using EOM_auth;

namespace EOM_stores.Ul.Operations
{
    public partial class costingPreview : Form
    {
        _ctrlChannel _socket;
        DataTable productInfo = new DataTable();
        void costsTable()
        {
            
            productInfo.Columns.Add("م");
            productInfo.Columns.Add("اسم المنتج");
            productInfo.Columns.Add("المقاس");
            productInfo.Columns.Add("الثمن");

            dgvProductCost.DataSource = productInfo;
            dgvProductCost.Columns[0].Width = 52;
        }

        
        void costing_Id()
        {
            //-----------------------------------------------
            _socket = new _ctrlChannel();
            DataTable ft = new DataTable();
            ft = _socket.getTargetId("@cost_Id", "get_Product_Cost");
            int indexer = ft.Rows[0].Field<int>("max(costingId)") + 1;
            pcCode.Text = indexer.ToString();
            //-----------------------------------------------
        }
        
        void clearFeilds()
        {
             txtProductName.Text="";
             txtPrdSize.Text = "";
             txtPrdPrice.Text = "";
        }

        void clearFeilds(int a)
        {
            txtCompanyName.Text = "";
            txtProductName.Text = "";
            txtPrdSize.Text = "";
            txtPrdPrice.Text = "";
            productInfo.Clear();


        }
        public costingPreview()
        {
            InitializeComponent();
            costing_Id();
            costsTable();
            txtCompanyName.Focus();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCompanyName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtProductName.Focus();
            }
        }

        private void txtProductName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPrdSize.Focus();
            }
        }

        private void txtPrdSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPrdPrice.Focus();
            }
        }

        private void txtPrdPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataRow ro = productInfo.NewRow();
                ro[0] = "*";
                ro[1] = txtProductName.Text;
                ro[2] = txtPrdSize.Text;
                ro[3] = txtPrdPrice.Text;
                productInfo.Rows.Add(ro);
                dgvProductCost.DataSource = productInfo;
                clearFeilds();
                txtProductName.Focus();
            }
        }

        private void piExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            _contr._cat cat = new _contr._cat();
            foreach(DataGridViewRow currentLine in dgvProductCost.Rows)
            {
                cat.insertNewCost(txtCompanyName.Text,currentLine.Cells[1].Value.ToString(), Convert.ToDouble(currentLine.Cells[2].Value), 
                    Convert.ToDouble(currentLine.Cells[3].Value),Convert.ToInt32(pcCode.Text));
                
            }

           if(MessageBox.Show("تم حفظ عرض الاسعار بنجاح /n هل تريد طباعة القائمة ؟؟","حفظ",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                _contr.products._prdc products= new _contr.products._prdc();


                Rpt.productCosyingPreview productCost= new Rpt.productCosyingPreview();
                Rpt.rptContainer reportCont = new Rpt.rptContainer();

                productCost.SetDataSource(products.PrintAllProducts(Convert.ToInt32(pcCode.Text)));

                reportCont.reportViewer.ReportSource = productCost;
                reportCont.Show();
                reportCont.Location = new System.Drawing.Point(20, 50);
            }
            {
                
            }
           
        }

        private void btnCurrPrint_Click(object sender, EventArgs e)
        {
            _contr.products._prdc products = new _contr.products._prdc();
            
            Rpt.productCosyingPreview productCost = new Rpt.productCosyingPreview();
            Rpt.rptContainer reportCont = new Rpt.rptContainer();

            productCost.SetDataSource(products.PrintAllProducts(Convert.ToInt32(pcCode.Text)));

            reportCont.reportViewer.ReportSource = productCost;
            reportCont.Show();
            reportCont.Location = new System.Drawing.Point(20, 50);
        }
    }
}
