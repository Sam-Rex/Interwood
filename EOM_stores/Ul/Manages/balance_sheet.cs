using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using EOM_auth;
using EOM_stores;
using System.Data;
using System.Linq;



namespace EOM_stores.Ul.Manages
{
    public partial class balance_sheet : Form
    {
        _ctrlChannel _socket;
        _contr.accounts._getAccs gss;
        public balance_sheet()
        {

            InitializeComponent();
            _socket = new _ctrlChannel();
            gss = new _contr.accounts._getAccs();
            //reciveBlance.Columns[0].Width = 150;
            //reciveBlance.Columns[1].Width = 200;
            reciveBlance.DataSource = gss.acc4Blance(1);
            reciveBlance.Columns[2].Visible = false;

            //outBlance.Columns[0].Width = 100;
            //outBlance.Columns[1].Width = 200;
            outBlance.DataSource = gss.acc4Blance(2);
            outBlance.Columns[2].Visible = false;
            

        }

        private void piExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void balance_sheet_Load(object sender, EventArgs e)
        {
            calculateIn();
            calculateOut();

            if(Convert.ToDouble(inTotal.Text) > Convert.ToDouble(outTotal.Text))
            {
                txtStatus.Text = Convert.ToString(Convert.ToDouble(inTotal.Text) - Convert.ToDouble(outTotal.Text));
            }

            else if (Convert.ToDouble(inTotal.Text) < Convert.ToDouble(outTotal.Text))
            {
                txtStatus.Text = Convert.ToString(Convert.ToDouble(outTotal.Text) - Convert.ToDouble(inTotal.Text));
                lblStatus.Text = "مدين";
                pnStatus.BackColor = System.Drawing.Color.Red;

            }
            else if(Convert.ToDouble(inTotal.Text) == Convert.ToDouble(outTotal.Text))
            {
                lblStatus.Text = "مستقر";
                pnStatus.BackColor = System.Drawing.Color.FromArgb(255, 223, 102);
            }
        }

        void calculateIn()
        {
            inTotal.Text =
                    (from DataGridViewRow drv in reciveBlance.Rows
                     where drv.Cells[0].FormattedValue.ToString() != string.Empty
                     select Convert.ToDouble(drv.Cells[0].FormattedValue)).Sum().ToString();
        }

        void calculateOut()
        {
            outTotal.Text =
                    (from DataGridViewRow drv in outBlance.Rows
                     where drv.Cells[0].FormattedValue.ToString() != string.Empty
                     select Convert.ToDouble(drv.Cells[0].FormattedValue)).Sum().ToString();
        }

      
    }
}
