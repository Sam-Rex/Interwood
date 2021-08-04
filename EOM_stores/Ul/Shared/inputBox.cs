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
    public partial class inputBox : Form
    {
        public  string section = "reciveOrder";
        public inputBox()
        {
            InitializeComponent();
        }

        private void piExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void inputText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                reciptName.Focus();
            }
        }

        private void inputText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (section == "section ")
            {
                /*
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13)
                {
                    e.Handled = true;

                }
                */
            }
            else
            {
                
            }
        
        }

        private void reciptName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Close();
            }
        }
    }
}
