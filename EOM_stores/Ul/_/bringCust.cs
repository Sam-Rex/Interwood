using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EOM_stores.Ul.__
{
    public partial class bringCust : Form
    {
        public bringCust()
        {
            InitializeComponent();
            EOM_auth._ctrlChannel.InitializeDb();
        }
        
        private void txtUsr_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Enter)
            {
                txtPasswod.Focus();
            }
            
        }

        private void txtPasswod_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyCode==Keys.Enter)
            {
                if (txtUsr != null && txtPasswod != null)
                {
                    DataTable auCont = new DataTable();

                    _contr.__.primaryAouth prA = new _contr.__.primaryAouth();
                    auCont = prA.checkAvUsr(txtUsr.Text, txtPasswod.Text);

                    if (auCont.Rows.Count > 0)
                    {
                        
                        dataChannel.Aouthentications aouth = new dataChannel.Aouthentications(); 
                        Program._usrIden = Convert.ToInt32(auCont.Rows[0]["usrId"].ToString());
                        Program._fullUsrName= auCont.Rows[0]["FullName"].ToString();
                        aouth.authenticate(auCont.Rows[0]["usrType"].ToString());
                        homeScreen.decorateHomeScreen.txtEmp.Text= auCont.Rows[0]["FullName"].ToString();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("ربما اسم المستخدم او كلمة السر الذي أدخلته غير صحيح ");
                        // give it message that username or password is wrong 
                    }
                }
            }
        }

        private void bringCust_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.LWin && e.KeyCode == Keys.Tab) || (e.KeyCode == Keys.RWin && e.KeyCode == Keys.Tab) || (e.KeyCode == Keys.Alt && e.KeyCode == Keys.F4))
            {

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsr != null && txtPasswod != null)
            {
                DataTable auCont = new DataTable();
                
                _contr.__.primaryAouth prA = new _contr.__.primaryAouth();
                auCont = prA.checkAvUsr(txtUsr.Text, txtPasswod.Text);

                if (auCont.Rows.Count > 0)
                {
                    homeScreen.decorateHomeScreen.mainNavigationMenu.Enabled = true;

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("ربما اسم المستخدم او كلمة السر الذي أدخلته غير صحيح ");
                    // give it message that username or password is wrong 
                }
            }
        }
    }
}
