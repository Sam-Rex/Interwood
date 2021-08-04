using System;
using System.Linq;
using System.Data;
using MySql.Data.MySqlClient;
using EOM_auth;
namespace EOM_stores._contr.workers
{
   
    class _ctrlWorkers
    {
        private _ctrlChannel _socket;
        private string _fName, _lName, _phone_no, _address, _email, _hireDate;
        public int _identityID;
        private int _cityId, _conId, _status, _hostel;
        private double _salary;
        private byte[] _worPict;

        private string fName { get; set; }
        private string lName { get; set; }
        private string phone_no { get; set; }
        private string address { get; set; }
        private string email { get; set; }
        private int hostel { get; set; }
        private int status{ get; set; }
        private string hireDate { get; set; }
        private int identityID { get; set; }
        private int cityId { get; set; }
        private int conId { get; set; }
        private double salary { get; set; }
        private byte[] worPict { get; set; }

        void prep()
        {
            _fName = fName;
            _lName = lName;
            _phone_no = phone_no;
            _address = address;
            _email = email;
            _hireDate = hireDate;
            _identityID = identityID;
            _hostel = hostel;
            _cityId = cityId;
            _conId = conId;
            _status = status;
            _salary = salary;
            _worPict = worPict;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_fName"></param>
        /// <param name="_lName"></param>
        /// <param name="_phone_no"></param>
        /// <param name="_address"></param>
        /// <param name="_email"></param>
        /// <param name="_hireDate"></param>
        /// <param name="_salary"></param>
        /// <param name="_cityId"></param>
        /// <param name="_conId"></param>
        /// <param name="_status"></param>
        /// <param name="_hostel"></param>
        /// <param name="_worPict"></param>

        public void insertWorker(string _fName, string _lName, string _phone_no, string _address, string _email, string _hireDate,
            double _salary,int _cityId, int _conId,int _status,int _hostel,byte[] _worPict)
        {
            _socket = new _ctrlChannel();

            DataTable ft = new DataTable();

            ft = _socket.getTargetId("@identityId", "getIdenId");
            _identityID = ft.Rows[0].Field<int>("Max(identify)");

            MySqlParameter[] param = new MySqlParameter[15];

            param[0] = new MySqlParameter("@wfName", MySqlDbType.VarChar)
            { Value = _fName, Direction = ParameterDirection.Input };

            param[1] = new MySqlParameter("@wlName", MySqlDbType.VarChar)
            { Value = _lName, Direction = ParameterDirection.Input };
            
            param[2] = new MySqlParameter("@waddress", MySqlDbType.VarChar)
            { Value = _address, Direction = ParameterDirection.Input };

            param[3] = new MySqlParameter("@wemail", MySqlDbType.VarChar)
            { Value = _email, Direction = ParameterDirection.Input };

            param[4] = new MySqlParameter("@wstatus", MySqlDbType.Int32)
            { Value = _status, Direction = ParameterDirection.Input };

            param[5] = new MySqlParameter("@whiredate", MySqlDbType.VarChar)
            { Value = _hireDate, Direction = ParameterDirection.Input };

            param[6] = new MySqlParameter("@wsalary", MySqlDbType.Double)
            { Value = _salary, Direction = ParameterDirection.Input };

            param[7] = new MySqlParameter("@wphone", MySqlDbType.VarChar)
            { Value = _phone_no, Direction = ParameterDirection.Input };

            param[8] = new MySqlParameter("@wregisteredDate", MySqlDbType.VarChar)
            { Value = DateTime.Now.ToShortDateString(), Direction = ParameterDirection.Input };

            param[9] = new MySqlParameter("@wPict", MySqlDbType.LongBlob)
            { Value = _worPict, Direction = ParameterDirection.Input };
            
            param[10] = new MySqlParameter("@wnation", MySqlDbType.Int32)
            { Value = _conId, Direction = ParameterDirection.Input };

            param[11] = new MySqlParameter("@wcityId", MySqlDbType.Int32)
            { Value = _cityId, Direction = ParameterDirection.Input };

            param[12] = new MySqlParameter("@widentity", MySqlDbType.Int32)
            { Value = _identityID, Direction = ParameterDirection.Input };

            param[13] = new MySqlParameter("@whostelId", MySqlDbType.Int32)
            { Value = _hostel, Direction = ParameterDirection.Input };
            
            param[14] = new MySqlParameter("@wworId", MySqlDbType.Int32)
            { Value =DBNull.Value, Direction = ParameterDirection.Output };

            _socket.connect();
            _socket.Transfare("AddNewWorker", param);
            _socket.disConnect();
        }

        /// <summary>
        /// get and set to send worker id to database for check avilability operations ...
        /// </summary>
        /// <param name="_workerId"></param>
        public void insWorker4Chaeck(int _workerId)
        {
            //workerTempId
            _socket = new _ctrlChannel();
            MySqlParameter[] param = new MySqlParameter[1];

            param[0] = new MySqlParameter("@cworId", MySqlDbType.Int32)
            { Value = _workerId, Direction = ParameterDirection.Input };
           
            _socket.connect();
            _socket.Transfare("checkWorkerAvi", param);
            _socket.disConnect();
        }
    }
}
