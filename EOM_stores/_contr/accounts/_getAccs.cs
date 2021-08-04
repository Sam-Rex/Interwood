using System;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data;
using EOM_auth;
namespace EOM_stores._contr.accounts
{
    class _getAccs
    {
        _ctrlChannel _socket;

        private int _ownerId;
        private string _ltrId;
        private int ownerId { get; set; }
        private string ltrId { get; set; }

        void prepare()
        {
            _ownerId = ownerId;
            _ltrId = ltrId;
        }

        /// <summary>
        /// the prameter account id delivered to the stored procedure to return account details to use in update operation
        /// </summary>
        /// <param name="_acotId"></param>
        /// <returns></returns>
        public DataTable accs4Edit(int _acotId)
        {
            _socket = new _ctrlChannel();
            MySqlParameter[] zair = new MySqlParameter[8];

            zair[0] = new MySqlParameter("@aacotId", MySqlDbType.Int32)
            {Value = _acotId, Direction = ParameterDirection.InputOutput };

            zair[1] = new MySqlParameter("@aacoType", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };


            zair[2] = new MySqlParameter("@aacoDirection", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };


            zair[3] = new MySqlParameter("@acheqeSerialNo", MySqlDbType.VarChar)
            {Direction = ParameterDirection.Output};

            zair[4] = new MySqlParameter("@aacoStatement", MySqlDbType.VarChar)
            {Direction = ParameterDirection.Output};

            zair[5] = new MySqlParameter("@aprice", MySqlDbType.Double)
            {Direction = ParameterDirection.Output};

            zair[6] = new MySqlParameter("@aacoIssuer", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };
            
            zair[7] = new MySqlParameter("@aaccRefarePhoto", MySqlDbType.LongBlob)
            {Direction = ParameterDirection.Output};

            DataTable _account = new DataTable();
            _account = _socket.storeData("acc4_Edit",zair);
            _socket.disConnect();
            return _account;
        }

        //------------------------------------------------------------
        

        public DataTable getTargetAcc(int _ownerId, string _ltrId)
        {
            _socket = new _ctrlChannel();
            MySqlParameter[] zair = new MySqlParameter[4];

            zair[0] = new MySqlParameter("@ownerId", MySqlDbType.Int32)
            { Value = _ownerId, Direction = ParameterDirection.Input };

            zair[1] = new MySqlParameter("@ownerLtr", MySqlDbType.VarChar)
            { Value= _ltrId,Direction = ParameterDirection.Input };

            zair[2] = new MySqlParameter("@account_No", MySqlDbType.Int32)
            { Direction = ParameterDirection.Output };

            zair[3] = new MySqlParameter("@totalCost", MySqlDbType.Double)
            { Direction = ParameterDirection.Output };


            DataTable _workers = new DataTable();
            _workers = _socket.storeData("getTargetAccount", zair);
            _socket.disConnect();
            return _workers;
        }

        
        public DataTable account4previrew(string _ltrId)
        {
            _socket = new _ctrlChannel();

            MySqlParameter[] zair = new MySqlParameter[1];

            zair[0] = new MySqlParameter("@letterId", MySqlDbType.VarChar)
            { Value= _ltrId, Direction = ParameterDirection.Input };

            DataTable _account = new DataTable();
            _account = _socket.storeData("previewAccounts",zair);
            _socket.disConnect();
            return _account;
        }

        public DataTable acc4Blance(int _acotDirection)
        {
            _socket = new _ctrlChannel();
            MySqlParameter[] zair = new MySqlParameter[5];

            zair[0] = new MySqlParameter("@acotDirection", MySqlDbType.Int16)
            { Value = _acotDirection, Direction = ParameterDirection.InputOutput };

            zair[1] = new MySqlParameter("@aacoId", MySqlDbType.Int32)
            { Direction = ParameterDirection.Output };


            zair[2] = new MySqlParameter("@acoStatement", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };


            zair[3] = new MySqlParameter("@accoDate", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };

            zair[4] = new MySqlParameter("@acoPrice", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };

          
            DataTable _account = new DataTable();
            _account = _socket.storeData("getBlance", zair);
            _socket.disConnect();
            return _account;
        }

        public DataTable getCats4Blance(string _Kind)
        {
            _socket = new _ctrlChannel();
            MySqlParameter[] zair = new MySqlParameter[1];
            zair[0] = new MySqlParameter("@ATkind", MySqlDbType.VarChar)
            { Value = _Kind, Direction = ParameterDirection.Input };

            DataTable _categoryDetails = new DataTable();
            _categoryDetails = _socket.storeData("accounts_blance", zair);
            _socket.disConnect();
            return _categoryDetails;
        }

        public DataTable getEmp_Salaries()
        {
            _socket = new _ctrlChannel();

             DataTable _salaries = new DataTable();
            _salaries = _socket.storeData("get_employee_salaries", null);
            _socket.disConnect();
            return _salaries;
        }

        public DataTable getWo_Salaries()
        {
            _socket = new _ctrlChannel();

            DataTable _salaries = new DataTable();
            _salaries = _socket.storeData("get_worker_Salaries",null);
            _socket.disConnect();
            return _salaries;
        }
    }
}
