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
    public partial class changePasswd : Form
    {
        public changePasswd()
        {
            InitializeComponent();
            empName.Text = Program._fullUsrName;
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
            if(curHash.Text!=string.Empty && newHash.Text==reNewHash.Text)
            {
                _contr.__.primaryAouth priAouth = new _contr.__.primaryAouth();
                priAouth.EditHash(curHash.Text, newHash.Text);
                MessageBox.Show("تم تعديل كلمة المرور بنجاح ","تغيير كلمة المرور",MessageBoxButtons.OK,MessageBoxIcon.Information);
                curHash.Text = "";
                newHash.Text = "";
                reNewHash.Text = "";
                this.Close();

            }
            else if(newHash.Text!=reNewHash.Text)
            {
                MessageBox.Show("يجب ان تطابق كلمة المرور و تكرارها !!","تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                newHash.Text = "";
                reNewHash.Text = "";
                newHash.Focus();
            }
            else
            {
                MessageBox.Show("كلمة المرور الحالية لا تطابق كلمةالمرور ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                curHash.Text = "";
                newHash.Text = "";
                reNewHash.Text = "";
                curHash.Focus();


            }

        }
    }
}
