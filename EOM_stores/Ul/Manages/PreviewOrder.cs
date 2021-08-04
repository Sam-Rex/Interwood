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
    public partial class PreviewOrder : Form
    {
        public PreviewOrder()
        {
            InitializeComponent();
        }

        private void piExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvOrderDetails_Click(object sender, EventArgs e)
        {
            lblCatName.Text = dgvOrderDetails.CurrentRow.Cells[0].Value.ToString();
            lblDimentions.Text = dgvOrderDetails.CurrentRow.Cells[1].Value.ToString();
            lblThickness.Text = dgvOrderDetails.CurrentRow.Cells[2].Value.ToString();
            lblQte.Text = dgvOrderDetails.CurrentRow.Cells[3].Value.ToString();
            lblUnitPrice.Text = dgvOrderDetails.CurrentRow.Cells[4].Value.ToString();
            lblTotalPrice.Text = dgvOrderDetails.CurrentRow.Cells[5].Value.ToString();
        }

        private void dgvOrderDetails_Enter(object sender, EventArgs e)
        {
            try
            {
                dgvOrderDetails.Columns[6].Visible = false;
                orderQte.Text = dgvOrderDetails.CurrentRow.Cells[6].Value.ToString();
                orderQte.Text = dgvOrderDetails.CurrentRow.Cells[6].Value.ToString();
                lbl_totalFinalCost.Text = Convert.ToString(Convert.ToDouble(lblTotalOrderAmount.Text) *
                    Convert.ToDouble(orderQte.Text));
            }
            catch(InvalidExpressionException ice) { }
            
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCurrPrint_Click(object sender, EventArgs e)
        {
            Shared.inputBox ib = new Shared.inputBox();
            ib.TopMost = true;
            ib.ShowDialog();
            string comName = ib.companyName.Text;
            string recName = ib.reciptName.Text;



            _contr.Saling.get_Orders gOrders = new _contr.Saling.get_Orders();


            Rpt.saleOrder orderReport = new Rpt.saleOrder();
            Rpt.rptContainer reportCont = new Rpt.rptContainer();

            orderReport.SetDataSource(gOrders.getOrderDetails4Print(Convert.ToInt32(lbl_OrderNo.Text), comName, recName));

            reportCont.reportViewer.ReportSource = orderReport;
            this.TopMost = false;
            reportCont.Show();
            reportCont.Location = new Point(20, 50);
        }
    }
}
