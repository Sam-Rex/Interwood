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
    public partial class AddUsrs : Form
    {
        public AddUsrs()
        {
            InitializeComponent();
            dataChannel.Aouthentications aout = new dataChannel.Aouthentications();
            cbEmployee.DataSource = aout.getEmp_usType("e");
            cbEmployee.DisplayMember = "اسم الموظف";
            cbEmployee.ValueMember = "معرف الموظف";

            usrType.DataSource = aout.getEmp_usType("t");
            usrType.DisplayMember = "نوع المستخدم";
            usrType.ValueMember = "معرف النوع";

        }

        private void piExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(confirmPasswd.Text == passwd.Text)
            {
                dataChannel.Aouthentications aout = new dataChannel.Aouthentications();
                aout.insNewUser(Convert.ToInt32(cbEmployee.SelectedValue), Convert.ToInt32(usrType.SelectedValue),
                    usrName.Text,passwd.Text);
                MessageBox.Show("تم ترقية المستخدم بنجاح");
                usrName.Clear();
                passwd.Clear();
                confirmPasswd.Clear();
            }
            else
            {
                MessageBox.Show("كلمتا المرور ليستا متطابقتين");
                passwd.Clear();
                confirmPasswd.Clear();
                passwd.Focus();
            }
            
        }

        private void confirmPasswd_Validating(object sender, CancelEventArgs e)
        {
          
        }

        private void confirmPasswd_Validated(object sender, EventArgs e)
        {
            if (confirmPasswd.Text != passwd.Text)
            {
                MessageBox.Show("كلمتا المرور ليستا متطابقتين");
                passwd.Clear();
                confirmPasswd.Clear();
                passwd.Focus();
            }
        }
    }
}
