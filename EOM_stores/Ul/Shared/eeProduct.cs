using System;
using System.Windows.Forms;

namespace EOM_stores.Ul.Shared
{
    public partial class eeProduct : Form
    {
       //homeScreen hos = new homeScreen();
        _contr.Shared.defineSection ds =new  _contr.Shared.defineSection();
        
        public eeProduct()
        {
            InitializeComponent();
            

        }

        private void entitiesEditor_Load(object sender, EventArgs e)
        {

        }

        private void piExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            //eeProduct ee = new eeProduct();
            ds.getSection("addProduct");
            
            this.Hide();
            
        }

        private void dgvEE_DoubleClick(object sender, EventArgs e)
        {
            product pr = new product();
            pr.Show();
            pr.Location = new System.Drawing.Point(20, 51);
            pr.aPTitle.Text = "تحديث منتج بالمعرف ";
            pr.aPcode.Text = dgvEE.CurrentRow.Cells[0].Value.ToString();
            pr.cbCategory.Text = dgvEE.CurrentRow.Cells[1].Value.ToString();
            pr.nuCuping.Text = dgvEE.CurrentRow.Cells[2].Value.ToString();
            pr.prDiam.Text = dgvEE.CurrentRow.Cells[3].Value.ToString();
            pr.prPrice.Text = dgvEE.CurrentRow.Cells[4].Value.ToString();
            pr.prWoodPrice.Text = dgvEE.CurrentRow.Cells[5].Value.ToString();
            pr.prInstall.Text = dgvEE.CurrentRow.Cells[6].Value.ToString();
            pr.prPrepare.Text = dgvEE.CurrentRow.Cells[7].Value.ToString();
            pr.prTrenspo.Text = dgvEE.CurrentRow.Cells[8].Value.ToString();
            pr.prSteels.Text = dgvEE.CurrentRow.Cells[9].Value.ToString();
            pr.prRenting.Text = dgvEE.CurrentRow.Cells[10].Value.ToString();
            pr.prQte.Text = dgvEE.CurrentRow.Cells[11].Value.ToString();
            pr.cbQuality.Text = dgvEE.CurrentRow.Cells[12].Value.ToString();
            pr.formSection = "updateProduct";
            this.Close();

        }

        private void btnEditRecord_Click(object sender, EventArgs e)
        {
            product pr = new product();
            pr.Show();
            pr.Location = new System.Drawing.Point(20,51);
            pr.aPTitle.Text = "تحديث منتج بالمعرف ";
            pr.aPcode.Text = dgvEE.CurrentRow.Cells[0].Value.ToString();
            pr.cbCategory.Text = dgvEE.CurrentRow.Cells[1].Value.ToString();
            pr.nuCuping.Text = dgvEE.CurrentRow.Cells[2].Value.ToString();
            pr.prDiam.Text = dgvEE.CurrentRow.Cells[3].Value.ToString();
            pr.prPrice.Text = dgvEE.CurrentRow.Cells[4].Value.ToString();
            pr.prWoodPrice.Text = dgvEE.CurrentRow.Cells[5].Value.ToString();
            pr.prInstall.Text = dgvEE.CurrentRow.Cells[6].Value.ToString();
            pr.prPrepare.Text = dgvEE.CurrentRow.Cells[7].Value.ToString();
            pr.prTrenspo.Text = dgvEE.CurrentRow.Cells[8].Value.ToString();
            pr.prSteels.Text = dgvEE.CurrentRow.Cells[9].Value.ToString();
            pr.prRenting.Text = dgvEE.CurrentRow.Cells[10].Value.ToString();
            pr.prQte.Text = dgvEE.CurrentRow.Cells[11].Value.ToString();
            pr.cbQuality.Text = dgvEE.CurrentRow.Cells[12].Value.ToString();
            pr.formSection = "updateProduct";
            this.Close();
        }

        private void dgvEE_MouseClick(object sender, MouseEventArgs e)
        {
            
                txtCost.Text = dgvEE.CurrentRow.Cells[13].Value.ToString();
                calculateCost(1);


        }

        private void btn1_Click(object sender, EventArgs e)
        {
            calculateCost(1);
        }

        public void calculateCost(int _percent)
        {
            lblCost.Text = Convert.ToString(Math.Round(Convert.ToDouble(dgvEE.CurrentRow.Cells[13].Value) + 
                (Convert.ToDouble(dgvEE.CurrentRow.Cells[13].Value) * _percent / 100)));
            txtPercent.Text = Convert.ToString(_percent+"%");
            txtPercent.ReadOnly = true;
            txtCost.ReadOnly = true;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            calculateCost(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            calculateCost(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            calculateCost(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            calculateCost(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            calculateCost(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            calculateCost(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            calculateCost(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            calculateCost(9);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            calculateCost(10);
        }

        private void btnPrdPrint_Click(object sender, EventArgs e)
        {
            
                Shared.inputBox ib = new Shared.inputBox();
                ib.TopMost = true;
                ib.section = "Total Product Cost";
               // ib.inputTitle.Text= "أدخل اسم العميل !";
                /*****/
                ib.ShowDialog();

                string inputValue = ib.companyName.Text;
                if (MessageBox.Show("هل تريد اغلاق هذه الصفحة؟", "إغلاق", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _contr.products._prdc product = new _contr.products._prdc();

                /*
                    Rpt.printProductCosts proReport = new Rpt.printProductCosts();
                    Rpt.rptContainer reportCont = new Rpt.rptContainer();

                    proReport.SetDataSource(product.PrintAllProducts(inputValue));
                    reportCont.reportViewer.ReportSource = proReport;
                    reportCont.TopMost = false;
                
                //reportCont.reportViewer.Size=new System.Drawing.Size(width+)   
                    reportCont.Size = new System.Drawing.Size(1050, 639);
                    this.Close();
                    reportCont.Show();
                    reportCont.Location = new System.Drawing.Point(20, 51);
                
                this.Close();
                */
            }



            else
            {

                /*
                _contr.products._prdc product = new _contr.products._prdc();

                Rpt.printProductCosts proReport = new Rpt.printProductCosts();
                Rpt.rptContainer reportCont = new Rpt.rptContainer();

                proReport.SetDataSource(product.PrintAllProducts(inputValue));
                reportCont.reportViewer.ReportSource = proReport;
                reportCont.Location = new System.Drawing.Point(20, 51);
                this.TopMost = false;
                reportCont.TopMost = false;
                reportCont.Show();
                reportCont.Location = new System.Drawing.Point(20, 51);
                */
            }

        }
    }
}
