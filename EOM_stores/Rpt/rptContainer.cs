using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EOM_stores.Rpt
{
    public partial class rptContainer : Form
    {
        public rptContainer()
        {
            InitializeComponent();
        }

        private void piExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
