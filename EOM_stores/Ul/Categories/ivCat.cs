using System;
using System.Windows.Forms;

namespace EOM_stores.Ul.Categories
{
    public partial class ivCat : Form
    {
        _contr._cat cat = new _contr._cat();
        public ivCat()
        {
            InitializeComponent();
            dgvIvCat.DataSource = cat.pursh_Cat();
            dgvIvCat.Columns[0].Visible = false;
        }

        private void piExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvIvCat_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
