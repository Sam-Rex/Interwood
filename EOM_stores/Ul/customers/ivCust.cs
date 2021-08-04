using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EOM_stores.Ul.customers
{
    public partial class ivCust : Form
    {
        public ivCust()
        {
            InitializeComponent();

            _contr._custCtrl custCtrl = new _contr._custCtrl();
            dgvIvCust.DataSource = custCtrl.getA_Customers();

            dgvIvCust.Columns[0].Visible = false;
            dgvIvCust.Columns[2].Visible = false;
            dgvIvCust.Columns[4].Visible = false;
            dgvIvCust.Columns[5].Visible = false;
            dgvIvCust.Columns[7].Visible = false;
            dgvIvCust.Columns[9].Visible = false;
            dgvIvCust.Columns[10].Visible = false;
        }

        private void piExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvIvCust_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
