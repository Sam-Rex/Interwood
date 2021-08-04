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
    public partial class eeAccount : Form
    {
        public eeAccount()
        {
            InitializeComponent();
            ItemsPreview();
            /*
            beginDate.CustomFormat = " dd - MM -yyyy";
            beginDate.Format = DateTimePickerFormat.Custom;
            endDate.CustomFormat = " dd - MM -yyyy";
            endDate.Format = DateTimePickerFormat.Custom;
            */
            //_contr.accounts._getAccs gacc = new _contr.accounts._getAccs();
            //dgvEEAccounts.DataSource = gacc.account4previrew();

        }

        private void piExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        void ItemsPreview()
        {
            try
            {

            
            _contr.accounts._getAccs gacc = new _contr.accounts._getAccs();

            DataTable woodContent = new DataTable();
            woodContent = gacc.getCats4Blance("woods");
            woodsQte.Text= woodContent.Rows[0]["الكمية الموجودة"].ToString();

            DataTable steelsContent = new DataTable();
            steelsContent = gacc.getCats4Blance("steels");
            steelsQte.Text = steelsContent.Rows[0]["الكمية الموجودة"].ToString();

            DataTable _bankIn = new DataTable();
            _bankIn = gacc.getCats4Blance("bankIn");
            bankIn.Text = _bankIn.Rows[0][0].ToString();

            DataTable _bankOut = new DataTable();
            _bankOut = gacc.getCats4Blance("bankOut");
            bankOut.Text = _bankOut.Rows[0][0].ToString();

            DataTable _boxIn = new DataTable();
            _boxIn = gacc.getCats4Blance("boxIn");
            boxIn.Text = _boxIn.Rows[0][0].ToString();

            DataTable _boxOut = new DataTable();
            _boxOut = gacc.getCats4Blance("boxOut");
            boxOut.Text = _boxOut.Rows[0][0].ToString();

            DataTable _wor_salaries = new DataTable();
            _wor_salaries = gacc.getWo_Salaries();
            worSalary.Text = _wor_salaries.Rows[0][0].ToString();

            DataTable _Emp_salaries = new DataTable();
            _Emp_salaries = gacc.getEmp_Salaries();
            employeeSalary.Text = _Emp_salaries.Rows[0][0].ToString();

            /*
            workerSalary.Text = Convert.ToString(gacc.getWo_Salaries());
            empSalary.Text = Convert.ToString(gacc.getEmp_Salaries());
            */

            divBank.Text = Convert.ToString(Convert.ToDouble(bankIn.Text) - Convert.ToDouble(bankOut.Text));
            divBox.Text = Convert.ToString(Convert.ToDouble(boxIn.Text) - Convert.ToDouble(boxOut.Text));
            }
            catch {
                

                steelsQte.Text = "00000";


                bankIn.Text = "00000";

                bankOut.Text = "00000";


                boxIn.Text = "00000";



                boxOut.Text = "00000";


                worSalary.Text = "00000";


                employeeSalary.Text = "00000";

                /*
                workerSalary.Text = Convert.ToString(gacc.getWo_Salaries());
                empSalary.Text = Convert.ToString(gacc.getEmp_Salaries());
                */

                divBank.Text = Convert.ToString(Convert.ToDouble(bankIn.Text) - Convert.ToDouble(bankOut.Text));
                divBox.Text = Convert.ToString(Convert.ToDouble(boxIn.Text) - Convert.ToDouble(boxOut.Text));
            }
        }
        void resizeDGV()
        {
            dgvEEAccounts.Columns[0].Width = 60;
            dgvEEAccounts.Columns[1].Width = 70;
            dgvEEAccounts.Columns[2].Width =200;
            dgvEEAccounts.Columns[3].Width = 60;
            dgvEEAccounts.Columns[4].Width = 70;
            dgvEEAccounts.Columns[7].Width = 250;
            dgvEEAccounts.Columns[8].Width = 70;
        }
        private void cbAccCategory_TextChanged(object sender, EventArgs e)
        {
            if(cbAccCategory.Text=="العملاء")
            {   
                _contr.accounts._getAccs gacc = new _contr.accounts._getAccs();
                dgvEEAccounts.DataSource = gacc.account4previrew("CU");
                resizeDGV();
            }
            else if (cbAccCategory.Text=="الموردين")
            {   
                _contr.accounts._getAccs gacc = new _contr.accounts._getAccs();
                dgvEEAccounts.DataSource = gacc.account4previrew("IMP");
                resizeDGV();
            }

            else if (cbAccCategory.Text == "الموظفين")
            {   
                _contr.accounts._getAccs gacc = new _contr.accounts._getAccs();
                dgvEEAccounts.DataSource = gacc.account4previrew("EM");
                resizeDGV();
            }

            else if (cbAccCategory.Text == "العمال")
            {
                _contr.accounts._getAccs gacc = new _contr.accounts._getAccs();
                dgvEEAccounts.DataSource = gacc.account4previrew("WK");
                resizeDGV();
            }

        }
    }
}
