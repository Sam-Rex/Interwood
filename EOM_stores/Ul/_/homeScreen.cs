using System;
using System.Drawing;
using System.Windows.Forms;
using EOM_stores.Ul;
using EOM_stores.Ul.__;
using EOM_auth;
using System.Data;
namespace EOM_stores.Ul
{
    public partial class homeScreen : Form
    {
        //private _ctrlChannel ctrlChannel; 
       
   
        private static homeScreen nullableHomeScreen;

        static void homeScreen_Close(object sender ,FormClosedEventArgs e)
        {
            nullableHomeScreen = null;
        }

        public static homeScreen decorateHomeScreen
        {
            get
            {
                if (nullableHomeScreen == null)
                {
                    nullableHomeScreen = new homeScreen();
                    nullableHomeScreen.FormClosed += new FormClosedEventHandler(homeScreen_Close);
                }return nullableHomeScreen;
            }

            
        }
        _contr.Shared.defineSection ds = new _contr.Shared.defineSection();

        public string homeFormSection = "homeScreen";
        public homeScreen()
        {
            InitializeComponent();
            
            //_ctrlChannel.InitializeDb();
            if (nullableHomeScreen == null) nullableHomeScreen = this;
            

            nullableHomeScreen.Show();
            nullableHomeScreen.txtEmp.Text = Program._fullUsrName;
            txtEmp.Text = Program._fullUsrName;
            lblTime.Text = DateTime.Now.ToLongTimeString();
            warningPanel();
           // bringCust brcust = new bringCust();brcust.ShowDialog();
           
        }
        

        private void pxExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void اضافةعميلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ds.getSection("addCustomer");
        }

        private void إضافةسجللموردToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ds.getSection("addImporters");
        }

       

        private void pxMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void اضافةموظفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ds.getSection("addEmployee");
        }

        private void اضافةمنتجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ds.getSection("addProduct");
         
        }

        private void ادارةالمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ds.getSection("manageProduct");
            
        }

        private void ادارةالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ds.getSection("manageCustomers");
        }

        private void إضافةصنفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ds.getSection("addCategory");
        }

        private void اضافةامراستلامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ds.getSection("reciveOrder");
         
        }

        private void اضافةامرتسليمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ds.getSection("saleOrder");
        }

        private void الارباح_والخسائرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ds.getSection("balanceSheet");
        }

        private void إدارةالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ds.getSection("manageImporters");
        }

        private void اضافةعاملجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ds.getSection("addWorker");
        }

        private void ادارةالعملاءToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ds.getSection("manageWorkers");
        }

        private void الحضوروالانصرافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ds.getSection("workersCheck");
        }

        private void اضافةحساب_Click(object sender, EventArgs e)
        {
            ds.getSection("inOutAccounts");
        }

        private void الايراداتوالمصروفاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void مرتباتالموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ds.getSection("empSalary");
        }

        private void مرتباتالعمالToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ds.getSection("worSalary");
        }

        private void ادارةاوامرالتسليمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ds.getSection("manageOrders");
        }

        private void ادارةاوامرالاستلامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ds.getSection("manageReciveOrders");
        }

        private void انشاءمستخدمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ds.getSection("addUser");
        }

        private void الموقف_الماليoolStripMenuItem_Click(object sender, EventArgs e)
        {
            ds.getSection("prevAccounts");
        }

        
        public void warningPanel()
        {
            try
            {

            
            _contr.accounts._getAccs gacc = new _contr.accounts._getAccs();

            DataTable woodContent, steelsContent = new DataTable();
            woodContent = gacc.getCats4Blance("woods");
            steelsContent = gacc.getCats4Blance("steels");

            if (Convert.ToDouble(woodContent.Rows[0][0])<20000)
            {
                panInformation.Visible = true;
            }
            else if(Convert.ToDouble(woodContent.Rows[0][0]) >= 20000)
            {
                panInformation.Visible = false;
            }
            
            else if(Convert.ToDouble(steelsContent.Rows[0][0])<10000)
            {
                panInformation.Visible = true;
                lblInfoTitle.Text = "كمية الحديد لديك أقل من 10000 جنيه ";
                lblInfoDetails.Text = "يرجى الاتصال بالموردين  لتوفير الاصناف المطلوبة في أقرب فترة ممكنة |  نلفت انتباهك انه في حالة اضافة منتجات جديدة سيتم احتساب كمية الحديد بالسالب و هذا قد يحدث خللاً بالحسابات";
            }

                else if (Convert.ToDouble(steelsContent.Rows[0][0]) == 0)
                {
                    panInformation.Visible = true;
                    lblInfoTitle.Text = "لا يوجد حديد بالمخزن !! ";
                    lblInfoDetails.Text = "يرجى الاتصال بالموردين  لتوفير الاصناف المطلوبة في أقرب فترة ممكنة ";
                }

                else if (Convert.ToDouble(steelsContent.Rows[0][0]) < 10000)
                {
                    panInformation.Visible = true;
                    lblInfoTitle.Text = "كمية الحديد لديك أقل من 10000 جنيه ";
                    lblInfoDetails.Text = "يرجى الاتصال بالموردين  لتوفير الاصناف المطلوبة في أقرب فترة ممكنة |  نلفت انتباهك انه في حالة اضافة منتجات جديدة سيتم احتساب كمية الحديد بالسالب و هذا قد يحدث خللاً بالحسابات";
                }
                else if(Convert.ToDouble(steelsContent.Rows[0][0]) >= 10000)
            {
                panInformation.Visible = false;
            }
            }catch(InvalidCastException ice) { }
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            currentTime.Text = DateTime.Now.ToLongTimeString();
            //warningPanel();
        }

        private void signOut_Click(object sender, EventArgs e)
        {
            dataChannel.Aouthentications aouth = new dataChannel.Aouthentications();
            aouth.logOff();
        }

        private void انتاجيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ds.getSection("inOutAccounts");
        }

        private void سكنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ds.getSection("inOutAccounts");
        }

        private void مرتباتلاعمالtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            ds.getSection("worSalary");
        }

        private void مرتباتالموظفينtoolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ds.getSection("empSalary");
        }

        private void إضافةعرضأسعارtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            ds.getSection("productCost");
        }

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataChannel.Aouthentications aouth = new dataChannel.Aouthentications();
            aouth.logOff();
        }

        private void تغييركلمةالمرورToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ds.getSection("changeHash");
        }
    }
}
