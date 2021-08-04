using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EOM_stores.Ul.Manages
{
    public partial class previewPurchse : Form
    {
        void loadDetails()
        {
            _contr.Purshasing.getPurchase puController = new _contr.Purshasing.getPurchase();
            dgvPurchDetails.DataSource = puController.getReciveOrderDetails(Convert.ToInt32(lblPurchaseNo.Text));
        }
        public previewPurchse()
        {
            InitializeComponent();
            
            //loadDetails();


        }

        private void piExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvPurchDetails_Click(object sender, EventArgs e)
        {
            lblCatName.Text = dgvPurchDetails.CurrentRow.Cells[0].Value.ToString();
            lblDimentions.Text = dgvPurchDetails.CurrentRow.Cells[1].Value.ToString();
            lblThickness.Text = dgvPurchDetails.CurrentRow.Cells[2].Value.ToString();
            lblQte.Text = dgvPurchDetails.CurrentRow.Cells[3].Value.ToString();
            lblUnitPrice.Text = dgvPurchDetails.CurrentRow.Cells[4].Value.ToString();
            lblTotalPrice.Text = dgvPurchDetails.CurrentRow.Cells[5].Value.ToString();
            
        }

        private void btnCurrPrint_Click(object sender, EventArgs e)
        {
            
            _contr.Purshasing.getPurchase gpurch = new _contr.Purshasing.getPurchase();


            Rpt.reciveOrder puReport = new Rpt.reciveOrder();
            Rpt.rptContainer reportCont = new Rpt.rptContainer();

            puReport.SetDataSource(gpurch.perchasePrinting(Convert.ToInt32(lblPurchaseNo.Text)));
            
            reportCont.reportViewer.ReportSource = puReport;
            this.TopMost = false;
            this.Close();
            reportCont.Show();
            reportCont.Location = new Point(20, 50);
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
