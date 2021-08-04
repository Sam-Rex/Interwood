using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EOM_stores.Ul.Operations
{
    public partial class eeOrder : Form
    {
        
        public eeOrder()
        {
            InitializeComponent();
            try
            {
                _contr.Saling.get_Orders gor = new _contr.Saling.get_Orders();
                dgvEEOrder.DataSource = gor.getAllOrders(0);
            }
            catch {
                _contr.Saling.get_Orders gor = new _contr.Saling.get_Orders();
                dgvEEOrder.DataSource = gor.getAllOrders(0);
            }
            
        }

        private void piExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvEEOrder_DoubleClick(object sender, EventArgs e)
        {
            
            Ul.Manages.PreviewOrder prOrder = new Manages.PreviewOrder();
            prOrder.lbl_OrderNo.Text = dgvEEOrder.CurrentRow.Cells[0].Value.ToString();
            prOrder.lbl_CustomerName.Text = dgvEEOrder.CurrentRow.Cells[1].Value.ToString();
            prOrder.lbl_notes.Text = dgvEEOrder.CurrentRow.Cells[2].Value.ToString();
            prOrder.lblOrDate.Text = dgvEEOrder.CurrentRow.Cells[3].Value.ToString();
            prOrder.lblOrTime.Text = dgvEEOrder.CurrentRow.Cells[4].Value.ToString();
            prOrder.lbl_OrEmpName.Text = dgvEEOrder.CurrentRow.Cells[5].Value.ToString();
            
            _contr.Saling.get_Orders orderController = new _contr.Saling.get_Orders();
            prOrder.dgvOrderDetails.DataSource = orderController.getOrderDetails(Convert.ToInt32(dgvEEOrder.CurrentRow.Cells[0].Value.ToString()));
            /*
            
            prOrder.dgvOrderDetails.Columns[6].Visible = false;
            */
            // -----------------------------------
            prOrder.lblTotalOrderAmount.Text =
                (from DataGridViewRow row in prOrder.dgvOrderDetails.Rows
                 where row.Cells[5].FormattedValue.ToString()
                 != string.Empty
                 select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();
            /*
            prOrder.orderQte.Text = prOrder.dgvOrderDetails.CurrentRow.Cells[6].Value.ToString();
            prOrder.lbl_totalFinalCost.Text = Convert.ToString(Convert.ToDouble(prOrder.lblTotalOrderAmount.Text) *
                Convert.ToDouble(prOrder.orderQte.Text));
                */
            prOrder.TopMost = true;
            prOrder.Show();

            prOrder.Location = new Point(20, 50);
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contr.Saling.get_Orders gor = new _contr.Saling.get_Orders();
                dgvEEOrder.DataSource = gor.getAllOrders(Convert.ToInt32(txtSearch.Text));
            }
            catch {
                _contr.Saling.get_Orders gor = new _contr.Saling.get_Orders();
                dgvEEOrder.DataSource = gor.getAllOrders(0);
            }
            
        }
    }
}
