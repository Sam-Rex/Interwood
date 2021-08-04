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
    public partial class eeWorkers : Form
    {
        public string formSection = "viewWorkers";
        public eeWorkers()
        {
            InitializeComponent();
            if(formSection== "viewWorkers")
            {
                _contr.workers.getWorkers gw = new _contr.workers.getWorkers();
                dgvEEWorkers.DataSource = gw.getWorkrs();
                
            }

           
             
            
            
        }

        private void piExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
