using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EOM_stores.Ul.Shared
{
    public partial class ivProduct : Form
    {
        public ivProduct()
        {
            InitializeComponent();
            _contr._cat cate = new _contr._cat();
            
            dgvIvPrd.DataSource = cate.Order_Categories();
            
            dgvIvPrd.Columns[0].Visible = false;
            /*
            dgvIvPrd.Columns[5].Visible = false;
            dgvIvPrd.Columns[6].Visible = false;
            dgvIvPrd.Columns[7].Visible = false;
            dgvIvPrd.Columns[8].Visible = false;
            dgvIvPrd.Columns[9].Visible = false;
            dgvIvPrd.Columns[10].Visible = false;
            dgvIvPrd.Columns[12].Visible = false;
            //dgvIvPrd.Columns[13].Visible = true;
            dgvIvPrd.Columns[14].Visible = false;
            */

        }

        private void piExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvIvPrd_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
