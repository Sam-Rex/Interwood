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
    public partial class workerCheck : Form
    {

        _contr.workers.getWorkers gw;
        
        public workerCheck()
        {
            InitializeComponent();

            gw = new _contr.workers.getWorkers();
            dgvEEWorkers.DataSource = gw.getApcenWorkrs();
            dgvEEWorkers.AllowUserToAddRows = false;
            
        }

        private void piExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void btnReject_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("لم يتم حفظ الحضور هل تريد الحفظ ؟", "خروج", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow apRow in dgvEEWorkers.Rows)
                {
                    bool IsChecked = false;
                    try
                    {
                        IsChecked = (bool)apRow.Cells[0].Value;
                        if (IsChecked == true)
                        {
                            try
                            {
                                _contr.workers._ctrlWorkers ctrw = new _contr.workers._ctrlWorkers();
                                DataTable ds = new DataTable();
                                ds = gw.getApcenWorkrs();

                                int workerIndexer = ds.Rows[0].Field<int>("معرف العامل");

                                ctrw.insWorker4Chaeck(Convert.ToInt32(apRow.Cells[1].Value));
                                MessageBox.Show("تم تسجيل " + "  " + apRow.Cells["اسم العامل"].Value + " " + "على نظام الحضور و الانصراف");

                            }
                            catch (MySql.Data.MySqlClient.MySqlException)
                            {
                                MessageBox.Show("حدث خطأ على مستوى قاعدة البيانات : الرجاء ابلاغ مدير النظام ", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }


                        }
                    }
                    catch (NullReferenceException nrx) { }
                }
            }
            else
            {
                Close();
            }

            
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow apRow in dgvEEWorkers.Rows)
            {
                bool IsChecked = false;
                try
                {
                    IsChecked = (bool)apRow.Cells[0].Value;
                    if (IsChecked == true)
                    {
                        try
                        {
                            _contr.workers._ctrlWorkers ctrw = new _contr.workers._ctrlWorkers();
                            DataTable ds = new DataTable();
                            ds = gw.getApcenWorkrs();

                            int workerIndexer = ds.Rows[0].Field<int>("معرف العامل");

                            ctrw.insWorker4Chaeck(Convert.ToInt32(apRow.Cells[1].Value));
                            MessageBox.Show("تم تسجيل " + "  "+apRow.Cells["اسم العامل"].Value +" "+ "على نظام الحضور و الانصراف");
                            
                        }
                        catch (MySql.Data.MySqlClient.MySqlException)
                        {
                            MessageBox.Show("حدث خطأ على مستوى قاعدة البيانات : الرجاء ابلاغ مدير النظام ","اخطار",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        }
                        
                    }
                }
                catch (NullReferenceException nrx) {}
            }
        }
    }
}
