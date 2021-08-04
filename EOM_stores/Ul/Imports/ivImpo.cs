using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EOM_stores.Ul.Imports
{
    public partial class ivImpo : Form
    {
        public ivImpo()
        {
            InitializeComponent();
            _contr.imports._imp imp = new _contr.imports._imp();
             dgvIvImp.DataSource = imp.pursh_Importers();
             dgvIvImp.Columns[0].Visible = false;
            dgvIvImp.Columns[4].Visible = false;

        }

        private void piExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvIvImp_DoubleClick(object sender, EventArgs e)
        {
           
            Close();
        }
    }
}
