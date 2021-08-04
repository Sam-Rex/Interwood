using System;
using System.Linq;
using System.Windows.Forms;

namespace EOM_stores.Ul.Operations
{
    public partial class eeReciveOrder : Form
    {
        public eeReciveOrder()
        {
            InitializeComponent();
            try
            {
                _contr.Purshasing.getPurchase gpur = new _contr.Purshasing.getPurchase();
                dgvEEReciveOrder.DataSource = gpur.getAllReciveOrders(0);
            }
            catch(FormatException fx) {
                _contr.Purshasing.getPurchase gpur = new _contr.Purshasing.getPurchase();
                dgvEEReciveOrder.DataSource = gpur.getAllReciveOrders(0);
            }
            
        }

        private void piExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvEEReciveOrder_DoubleClick(object sender, EventArgs e)
        {
            Ul.Manages.previewPurchse prPurch = new Manages.previewPurchse();
            prPurch.lblPurchaseNo.Text = dgvEEReciveOrder.CurrentRow.Cells[0].Value.ToString();
            prPurch.lblImporterName.Text = dgvEEReciveOrder.CurrentRow.Cells[1].Value.ToString();
            prPurch.lblDetails.Text = dgvEEReciveOrder.CurrentRow.Cells[2].Value.ToString();
            prPurch.lblEmployee.Text = dgvEEReciveOrder.CurrentRow.Cells[3].Value.ToString();
            prPurch.lblDate.Text =dgvEEReciveOrder.CurrentRow.Cells[4].Value.ToString();
            prPurch.lblTime.Text = dgvEEReciveOrder.CurrentRow.Cells[5].Value.ToString();
            _contr.Purshasing.getPurchase puController = new _contr.Purshasing.getPurchase();
            prPurch.dgvPurchDetails.DataSource = puController.getReciveOrderDetails(Convert.ToInt32(dgvEEReciveOrder.CurrentRow.Cells[0].Value.ToString()));
            prPurch.lblTotalPurchAmount.Text =
                (from DataGridViewRow row in prPurch.dgvPurchDetails.Rows
                 where row.Cells[5].FormattedValue.ToString()
                 != string.Empty
                 select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();
            prPurch.TopMost = true;
            prPurch.Show();
            prPurch.Location = new System.Drawing.Point(20, 50);

        }

        private void txtReciveSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contr.Purshasing.getPurchase gpur = new _contr.Purshasing.getPurchase();
                dgvEEReciveOrder.DataSource = gpur.getAllReciveOrders(Convert.ToInt32(txtReciveSearch.Text));
            }catch(FormatException fx) {
                _contr.Purshasing.getPurchase gpur = new _contr.Purshasing.getPurchase();
                dgvEEReciveOrder.DataSource = gpur.getAllReciveOrders(0);
            }
            
        }
    }
}
