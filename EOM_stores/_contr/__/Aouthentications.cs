using System.Data;
using MySql.Data.MySqlClient;
using EOM_auth;



namespace EOM_stores.dataChannel
{
    class Aouthentications
    {


        ///
        /// <summary> this part knows as a manager that manage all users authentications so take a parameter like a value if user equal authentication open parts
        /// </summary>
        /// 


        private string _userType;
        private string userType { get; set; }
        void prep()
        {
            _userType = userType;
        }
        //private int _empId, _usrType;
        //private string _usrName, _passwod;

        //private int empId { get; set; }
        //int usrType { get; set; }
        //string usrName { get; set; }
        //string passwod { get; set; }

        //void prep()
        //{

        //    _empId = empId;
        //    _usrType= usrType;
        //    _usrName = usrName;
        //    _passwod = passwod;
        //}


        public DataTable getEmp_usType(string _status)
        {
            
            _ctrlChannel _socket = new _ctrlChannel();
            MySqlParameter[] param = new MySqlParameter[1];

            param[0] = new MySqlParameter("@stat", MySqlDbType.VarChar)
            { Value = _status, Direction = ParameterDirection.Input };
            DataTable _emp_type = new DataTable();
            _emp_type = _socket.storeData("getInfo4AddUsr", param);
            _socket.disConnect();
            return _emp_type;
        }

        public void logOff()
        {
            Ul.homeScreen.decorateHomeScreen.Reports.Enabled = false;
            Ul.homeScreen.decorateHomeScreen.Sale.Enabled = false;
            Ul.homeScreen.decorateHomeScreen.Purchase.Enabled = false;
            Ul.homeScreen.decorateHomeScreen.WorkersM.Enabled = false;
            Ul.homeScreen.decorateHomeScreen.Employees.Enabled = false;
            Ul.homeScreen.decorateHomeScreen.Customers.Enabled = false;
            Ul.homeScreen.decorateHomeScreen.Importers.Enabled = false;
            Ul.homeScreen.decorateHomeScreen.Accountant.Enabled = false;
            Ul.homeScreen.decorateHomeScreen.file.Enabled = false;
            Ul.homeScreen.decorateHomeScreen.storages.Enabled = false;
            Ul.homeScreen.decorateHomeScreen.Usrs.Enabled = false;
            Ul.homeScreen.decorateHomeScreen.الابلاغعنمشكلةتقنيةToolStripMenuItem.Enabled = false;
            Ul.homeScreen.decorateHomeScreen.Close();
            Ul.__.bringCust brc = new Ul.__.bringCust();
            brc.Show();

        }
        public void insNewUser(int _empId,int _usrType,string _usrName,string _passwod)
        {
            
           _ctrlChannel _socket = new _ctrlChannel();
            MySqlParameter[] param = new MySqlParameter[4];

            param[0] = new MySqlParameter("@uempId", MySqlDbType.Int32)
            { Value = _empId, Direction = ParameterDirection.Input };

            param[1] = new MySqlParameter("@utype", MySqlDbType.Int32)
            { Value = _usrType, Direction = ParameterDirection.Input };

            param[2] = new MySqlParameter("@usrNam", MySqlDbType.VarChar)
            { Value = _usrName, Direction = ParameterDirection.Input };

            param[3] = new MySqlParameter("@passwd", MySqlDbType.VarChar)
            { Value = _passwod, Direction = ParameterDirection.Input };

            _socket.connect();
            _socket.Transfare("upgradeUsr", param);
            _socket.disConnect();
        }

        public void authenticate(string _userType)
        {
            
            _contr.__.primaryAouth pr = new _contr.__.primaryAouth();

            if (_userType == "admin")
            {
                
                Ul.homeScreen.decorateHomeScreen.mainNavigationMenu.Enabled = true;

            }

            else if (_userType == "محاسب")
            {
                
                Ul.homeScreen.decorateHomeScreen.Reports.Enabled = true;
                Ul.homeScreen.decorateHomeScreen.Sale.Enabled = true;
                Ul.homeScreen.decorateHomeScreen.Purchase.Enabled = true;
                Ul.homeScreen.decorateHomeScreen.WorkersM.Enabled = false;
                Ul.homeScreen.decorateHomeScreen.Employees.Enabled = false;
                Ul.homeScreen.decorateHomeScreen.Customers.Enabled = true;
                Ul.homeScreen.decorateHomeScreen.Importers.Enabled = false; 
                Ul.homeScreen.decorateHomeScreen.Accountant.Enabled = true;
                Ul.homeScreen.decorateHomeScreen.file.Enabled = true;
                Ul.homeScreen.decorateHomeScreen.storages.Enabled=false;
                Ul.homeScreen.decorateHomeScreen.Usrs.Enabled = true;
                Ul.homeScreen.decorateHomeScreen.انشاءمستخدمToolStripMenuItem.Visible = false;
                Ul.homeScreen.decorateHomeScreen.انشاءمستخدمToolStripMenuItem.Enabled= false;
                Ul.homeScreen.decorateHomeScreen.تغييركلمةالمرورToolStripMenuItem.Visible = true;
                Ul.homeScreen.decorateHomeScreen.انشاءنسخةاحتياطيةToolStripMenuItem.Visible = false;
                Ul.homeScreen.decorateHomeScreen.استعادةنسخةاحتياطيةToolStripMenuItem.Visible = false;



                Ul.homeScreen.decorateHomeScreen.Reports.Visible= true;
                Ul.homeScreen.decorateHomeScreen.Sale.Visible= false;
                Ul.homeScreen.decorateHomeScreen.Purchase.Visible = false;
                Ul.homeScreen.decorateHomeScreen.WorkersM.Visible = false;
                Ul.homeScreen.decorateHomeScreen.Employees.Visible = false;
                Ul.homeScreen.decorateHomeScreen.Customers.Visible = false;
                Ul.homeScreen.decorateHomeScreen.Importers.Visible = false;
                Ul.homeScreen.decorateHomeScreen.Accountant.Visible = true;
                Ul.homeScreen.decorateHomeScreen.file.Visible = true;
                Ul.homeScreen.decorateHomeScreen.storages.Visible = false;
                Ul.homeScreen.decorateHomeScreen.Usrs.Visible = true;
                Ul.homeScreen.decorateHomeScreen.الابلاغعنمشكلةتقنيةToolStripMenuItem.Visible= true;

            }


            else if (_userType == "مدير عام")
            {

                Ul.homeScreen.decorateHomeScreen.Reports.Enabled = false;
                Ul.homeScreen.decorateHomeScreen.Sale.Enabled = true;
                Ul.homeScreen.decorateHomeScreen.Purchase.Enabled = true;
                Ul.homeScreen.decorateHomeScreen.WorkersM.Enabled = true;
                Ul.homeScreen.decorateHomeScreen.Employees.Enabled = true;
                Ul.homeScreen.decorateHomeScreen.Customers.Enabled = true;
                Ul.homeScreen.decorateHomeScreen.Importers.Enabled = true;
                Ul.homeScreen.decorateHomeScreen.Accountant.Enabled = false;
                Ul.homeScreen.decorateHomeScreen.file.Enabled = true;
                Ul.homeScreen.decorateHomeScreen.storages.Enabled = true;
                
                Ul.homeScreen.decorateHomeScreen.Usrs.Enabled = true;
                Ul.homeScreen.decorateHomeScreen.انشاءمستخدمToolStripMenuItem.Visible = false;
                Ul.homeScreen.decorateHomeScreen.انشاءمستخدمToolStripMenuItem.Enabled = false;
                Ul.homeScreen.decorateHomeScreen.تغييركلمةالمرورToolStripMenuItem.Visible = true;
                Ul.homeScreen.decorateHomeScreen.الابلاغعنمشكلةتقنيةToolStripMenuItem.Enabled = true;
                Ul.homeScreen.decorateHomeScreen.انشاءنسخةاحتياطيةToolStripMenuItem.Visible = false;
                Ul.homeScreen.decorateHomeScreen.استعادةنسخةاحتياطيةToolStripMenuItem.Visible = false;

                Ul.homeScreen.decorateHomeScreen.Reports.Visible = false;
                Ul.homeScreen.decorateHomeScreen.Sale.Visible = true;
                Ul.homeScreen.decorateHomeScreen.Purchase.Visible = true;
                Ul.homeScreen.decorateHomeScreen.WorkersM.Visible = true;
                Ul.homeScreen.decorateHomeScreen.Employees.Visible = true;
                Ul.homeScreen.decorateHomeScreen.Customers.Visible = true;
                Ul.homeScreen.decorateHomeScreen.Importers.Visible = true;
                Ul.homeScreen.decorateHomeScreen.Accountant.Visible = false;
                Ul.homeScreen.decorateHomeScreen.file.Visible= true;
                Ul.homeScreen.decorateHomeScreen.storages.Visible = true;
                Ul.homeScreen.decorateHomeScreen.Usrs.Visible = true;
                Ul.homeScreen.decorateHomeScreen.الابلاغعنمشكلةتقنيةToolStripMenuItem.Visible = true;
            }


            else if (_userType == "مدير شؤون العمال")
            {

                Ul.homeScreen.decorateHomeScreen.Reports.Enabled = false;
                Ul.homeScreen.decorateHomeScreen.Sale.Enabled = false;
                Ul.homeScreen.decorateHomeScreen.Purchase.Enabled = false;
                Ul.homeScreen.decorateHomeScreen.WorkersM.Enabled = true;
                Ul.homeScreen.decorateHomeScreen.Employees.Enabled = false;
                Ul.homeScreen.decorateHomeScreen.Customers.Enabled = false;
                Ul.homeScreen.decorateHomeScreen.Importers.Enabled = false;
                Ul.homeScreen.decorateHomeScreen.Accountant.Enabled = false;
                Ul.homeScreen.decorateHomeScreen.file.Enabled = true;
                Ul.homeScreen.decorateHomeScreen.storages.Enabled = false;
                
                Ul.homeScreen.decorateHomeScreen.Usrs.Enabled = true;
                Ul.homeScreen.decorateHomeScreen.انشاءمستخدمToolStripMenuItem.Visible = false;
                Ul.homeScreen.decorateHomeScreen.انشاءمستخدمToolStripMenuItem.Enabled = false;
                Ul.homeScreen.decorateHomeScreen.تغييركلمةالمرورToolStripMenuItem.Visible = true;
                Ul.homeScreen.decorateHomeScreen.الابلاغعنمشكلةتقنيةToolStripMenuItem.Enabled = true;
                Ul.homeScreen.decorateHomeScreen.انشاءنسخةاحتياطيةToolStripMenuItem.Visible = false;
                Ul.homeScreen.decorateHomeScreen.استعادةنسخةاحتياطيةToolStripMenuItem.Visible = false;


                Ul.homeScreen.decorateHomeScreen.Reports.Visible = false;
                Ul.homeScreen.decorateHomeScreen.Sale.Visible = false;
                Ul.homeScreen.decorateHomeScreen.Purchase.Visible = false;
                Ul.homeScreen.decorateHomeScreen.WorkersM.Visible = true;
                Ul.homeScreen.decorateHomeScreen.Employees.Visible = false;
                Ul.homeScreen.decorateHomeScreen.Customers.Visible = false;
                Ul.homeScreen.decorateHomeScreen.Importers.Visible = false;
                Ul.homeScreen.decorateHomeScreen.Accountant.Visible = false;
                Ul.homeScreen.decorateHomeScreen.file.Visible = true;
                Ul.homeScreen.decorateHomeScreen.storages.Visible = false;
                Ul.homeScreen.decorateHomeScreen.Usrs.Visible = true;
                Ul.homeScreen.decorateHomeScreen.الابلاغعنمشكلةتقنيةToolStripMenuItem.Visible = true;
            }


            else if (_userType == "مدير مخازن")
            {
                Ul.homeScreen.decorateHomeScreen.Reports.Enabled = false;
                Ul.homeScreen.decorateHomeScreen.Sale.Enabled = false;
                Ul.homeScreen.decorateHomeScreen.Purchase.Enabled = false;
                Ul.homeScreen.decorateHomeScreen.WorkersM.Enabled = false;
                Ul.homeScreen.decorateHomeScreen.Employees.Enabled = false;
                Ul.homeScreen.decorateHomeScreen.Customers.Enabled = false;
                Ul.homeScreen.decorateHomeScreen.Importers.Enabled = false;
                Ul.homeScreen.decorateHomeScreen.Accountant.Enabled = false;
                Ul.homeScreen.decorateHomeScreen.file.Enabled = true;
                Ul.homeScreen.decorateHomeScreen.storages.Enabled = true;

                Ul.homeScreen.decorateHomeScreen.Usrs.Enabled = true;
                Ul.homeScreen.decorateHomeScreen.انشاءمستخدمToolStripMenuItem.Visible = false;
                Ul.homeScreen.decorateHomeScreen.انشاءمستخدمToolStripMenuItem.Enabled = false;
                Ul.homeScreen.decorateHomeScreen.تغييركلمةالمرورToolStripMenuItem.Visible = true;
                Ul.homeScreen.decorateHomeScreen.الابلاغعنمشكلةتقنيةToolStripMenuItem.Enabled = true;

                Ul.homeScreen.decorateHomeScreen.Reports.Visible= false;
                Ul.homeScreen.decorateHomeScreen.Sale.Visible = false;
                Ul.homeScreen.decorateHomeScreen.Purchase.Visible = false;
                Ul.homeScreen.decorateHomeScreen.WorkersM.Visible = true;
                Ul.homeScreen.decorateHomeScreen.Employees.Visible = false;
                Ul.homeScreen.decorateHomeScreen.Customers.Visible = false;
                Ul.homeScreen.decorateHomeScreen.Importers.Visible = false;
                Ul.homeScreen.decorateHomeScreen.Accountant.Visible = false;
                Ul.homeScreen.decorateHomeScreen.file.Visible = true;
                Ul.homeScreen.decorateHomeScreen.storages.Visible = false;
                Ul.homeScreen.decorateHomeScreen.Usrs.Visible = true;
                Ul.homeScreen.decorateHomeScreen.الابلاغعنمشكلةتقنيةToolStripMenuItem.Visible = true;
                Ul.homeScreen.decorateHomeScreen.انشاءنسخةاحتياطيةToolStripMenuItem.Visible = false;
                Ul.homeScreen.decorateHomeScreen.استعادةنسخةاحتياطيةToolStripMenuItem.Visible = false;


            }

            else if (_userType == "بائع")
            {
                Ul.homeScreen.decorateHomeScreen.Reports.Enabled = false;
                Ul.homeScreen.decorateHomeScreen.Sale.Enabled = true;
                Ul.homeScreen.decorateHomeScreen.Purchase.Enabled = true;
                Ul.homeScreen.decorateHomeScreen.WorkersM.Enabled = false;
                Ul.homeScreen.decorateHomeScreen.Employees.Enabled = false;
                Ul.homeScreen.decorateHomeScreen.Customers.Enabled = false;
                Ul.homeScreen.decorateHomeScreen.Importers.Enabled = false;
                Ul.homeScreen.decorateHomeScreen.Accountant.Enabled = false;
                Ul.homeScreen.decorateHomeScreen.file.Enabled = true;
                Ul.homeScreen.decorateHomeScreen.storages.Enabled = false;
                Ul.homeScreen.decorateHomeScreen.Usrs.Enabled = true;
                Ul.homeScreen.decorateHomeScreen.انشاءمستخدمToolStripMenuItem.Visible = false;
                Ul.homeScreen.decorateHomeScreen.انشاءمستخدمToolStripMenuItem.Enabled = false;
                Ul.homeScreen.decorateHomeScreen.تغييركلمةالمرورToolStripMenuItem.Visible = true;

                Ul.homeScreen.decorateHomeScreen.الابلاغعنمشكلةتقنيةToolStripMenuItem.Enabled = true;
                Ul.homeScreen.decorateHomeScreen.انشاءنسخةاحتياطيةToolStripMenuItem.Visible = false;
                Ul.homeScreen.decorateHomeScreen.استعادةنسخةاحتياطيةToolStripMenuItem.Visible = false;

                Ul.homeScreen.decorateHomeScreen.Reports.Visible= false;
                Ul.homeScreen.decorateHomeScreen.Sale.Visible = true;
                Ul.homeScreen.decorateHomeScreen.Purchase.Visible = true;
                Ul.homeScreen.decorateHomeScreen.WorkersM.Visible = false;
                Ul.homeScreen.decorateHomeScreen.Employees.Visible = false;
                Ul.homeScreen.decorateHomeScreen.Customers.Visible = false;
                Ul.homeScreen.decorateHomeScreen.Importers.Visible = false;
                Ul.homeScreen.decorateHomeScreen.Accountant.Visible = false;
                Ul.homeScreen.decorateHomeScreen.file.Visible = true;
                Ul.homeScreen.decorateHomeScreen.storages.Visible = false;
                Ul.homeScreen.decorateHomeScreen.Usrs.Visible = true;
                
            }
        }

    }
}
