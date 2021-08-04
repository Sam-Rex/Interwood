using System;
using System.Data;
using MySql.Data.MySqlClient;
using EOM_auth;
namespace EOM_stores._contr.employees
{
    class empCtrl
    {
        //---------------------- ** declarations **
        private _ctrlChannel _socket;
        private string _fName, _midName, _lName, _phone_no, _address, _email,_hireDate;
        public int _identityID;
        private int _cityId, _conId, _specialize;
        private double _salary;
        private byte[] _empPict;

        private string fName { get; set; }
        private string midName{get;set;}
        private string lName { get; set; }
        private string phone_no { get; set; }
        private string address { get; set; }
        private string email { get; set; }
        private int specialize { get; set; }
        private string hireDate { get; set; }
        private int identityID { get; set; }
        private int cityId { get; set; }
        private int conId { get; set; }
        private double salary { get; set; }
        private byte[] empPict { get; set; }


        void prepare()
        {
            _fName = fName;
            _midName = midName;
            _lName = lName;
            _phone_no = phone_no;
            _address = address;
            _email = email;
            _specialize = specialize;
            _hireDate = hireDate;
            _identityID = identityID;
            _cityId = cityId;
            _salary = salary;
            _empPict = empPict;
            _conId = conId;
        }


        //---------------------- **end  declarations **

            /// <summary>
            /// country id is for nationalaty not the country of recedancity
            /// </summary>
            /// <param name="_fName"></param>
            /// <param name="_midName"></param>
            /// <param name="_lName"></param>
            /// <param name="_phone_no"></param>
            /// <param name="_address"></param>
            /// <param name="_email"></param>
            /// <param name="_salary"></param>
            /// <param name="_hireDate"></param>
            /// <param name="_cityId"></param>
            /// <param name="_conId"></param>
            /// <param name="_identiftyId"></param>
            /// <param name="_empPict"></param>
        public void insertNewEmpl(string _fName, string _midName, string _lName, string _phone_no, string _address, string _email, 
            double _salary,string _hireDate,int _specialize, int _cityId, int _conId,byte[] _empPict)
        {

            

            _socket = new _ctrlChannel();

            DataTable ft = new DataTable();

            ft = _socket.getTargetId("@identityId", "getIdenId");
             _identityID = ft.Rows[0].Field<int>("Max(identify)");


            MySqlParameter[] zair = new MySqlParameter[14];
            

            zair[0] = new MySqlParameter("@pfName", MySqlDbType.VarChar)
            { Value = _fName ,Direction=ParameterDirection.Input};

            zair[1] = new MySqlParameter("@pmidName", MySqlDbType.VarChar)
            { Value = _midName, Direction = ParameterDirection.Input };

            zair[2] = new MySqlParameter("@lNamep", MySqlDbType.VarChar)
            { Value = _lName, Direction = ParameterDirection.Input };

            zair[3] = new MySqlParameter("@pphone", MySqlDbType.VarChar)
            {Value = _phone_no, Direction = ParameterDirection.Input };

            zair[4] = new MySqlParameter("@paddress", MySqlDbType.VarChar)
            { Value = _address, Direction = ParameterDirection.Input };

            zair[5] = new MySqlParameter("@pemail", MySqlDbType.VarChar)
            { Value = _email, Direction = ParameterDirection.Input };

            zair[6] = new MySqlParameter("@psalary", MySqlDbType.VarChar)
            { Value = _salary, Direction = ParameterDirection.Input };

            zair[7] = new MySqlParameter("@pspecialize", MySqlDbType.Int32)
            { Value = _specialize, Direction = ParameterDirection.Input };

            zair[8] = new MySqlParameter("@phireDate", MySqlDbType.VarChar)
            { Value = _hireDate, Direction = ParameterDirection.Input };


            zair[9] = new MySqlParameter("@pemplPict", MySqlDbType.LongBlob)
            { Value = _empPict, Direction = ParameterDirection.Input };

            zair[10] = new MySqlParameter("@identitypId", MySqlDbType.Int32)
            { Value = _identityID, Direction = ParameterDirection.Input };

            zair[11] = new MySqlParameter("@citypId", MySqlDbType.Int32)
            { Value = _cityId , Direction = ParameterDirection.Input };

            zair[12] = new MySqlParameter("@conpId", MySqlDbType.Int32)
            { Value = _cityId, Direction = ParameterDirection.Input };

            zair[13] = new MySqlParameter("@emppId", MySqlDbType.Int32)
            { Value = DBNull.Value, Direction = ParameterDirection.Output };


            _socket.connect();
            _socket.Transfare("addNewEmployee", zair);
            _socket.disConnect();


        }


        public void updateEmpl(int empId, string fName, string midName, string lName, string phone, string address, string Email, char status, char gender, DateTime hireDate, int cityId, int conId, int accId, int identiftyId)
        {
            _socket = new _ctrlChannel();
            MySqlParameter[] zair = new MySqlParameter[13];


            zair[0] = new MySqlParameter("@empId", MySqlDbType.Int16, 5)
            { Value = empId };

            zair[1] = new MySqlParameter("@fName", MySqlDbType.VarChar, 15)
            { Value = fName };

            zair[2] = new MySqlParameter("@midNName", MySqlDbType.VarChar, 30)
            { Value = midName };

            zair[3] = new MySqlParameter("@lName", MySqlDbType.VarChar, 20)
            { Value = lName };


            zair[4] = new MySqlParameter("@phone", MySqlDbType.VarChar, 15)
            {
                Value = phone
            };

            zair[5] = new MySqlParameter("@address", MySqlDbType.VarChar, 150)
            { Value = address };

            zair[6] = new MySqlParameter("@email", MySqlDbType.VarChar, 45)
            { Value = Email };

            zair[7] = new MySqlParameter("@status", MySqlDbType.VarChar, 1)
            { Value = status };

            zair[8] = new MySqlParameter("@gender", MySqlDbType.VarChar, 1)
            { Value = gender };

            zair[9] = new MySqlParameter("@hireDate", MySqlDbType.DateTime)
            { Value = hireDate };

            zair[10] = new MySqlParameter("@cityId", MySqlDbType.Int16, 5)
            { Value = cityId };
            

            zair[11] = new MySqlParameter("@accId", MySqlDbType.Int16, 5)
            {
                Value = accId
            };


            zair[12] = new MySqlParameter("@identityId", MySqlDbType.Int16, 5)
            { Value = identiftyId };

            _socket.connect();
            _socket.Transfare("updateEmpl", zair);
            _socket.disConnect();


        }


        public void DeleteEmpl(int empId)
        {
            _socket = new _ctrlChannel();
            MySqlParameter[] zair = new MySqlParameter[1];


            zair[0] = new MySqlParameter("@empId", MySqlDbType.Int16, 5)
            { Value = empId };
            
            _socket.connect();
            _socket.Transfare("deleteEmpl", zair);
            _socket.disConnect();


        }

        

        public DataTable searchOnEmpl(int _cusrId, string _custName)
        {
            DataTable serEmpl = new DataTable();
            MySqlParameter[] Zair = new MySqlParameter[2];
            serEmpl = _socket.storeData("searchEmployee", Zair);
            Zair[0] = new MySqlParameter("@EmpId", MySqlDbType.Int16, 5);
            Zair[0].Value = _cusrId;

            Zair[1] = new MySqlParameter("@fName", MySqlDbType.VarChar, 15);
            Zair[1].Value = _custName;
            _socket.disConnect();
            return serEmpl ;
        }


    }
}
