using System;
using System.Windows.Forms;

namespace EOM_stores.Ul.Manages
{
    public partial class eeImporters : Form
    {
        _contr.imports.getImporters getImp;
        public eeImporters()
        {
            InitializeComponent();
            getImp = new _contr.imports.getImporters();
            dgvEEImporters.DataSource = getImp.getImp4edit();
            dgvEEImporters.Columns[0].Visible = false;
        }

        private void piExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
