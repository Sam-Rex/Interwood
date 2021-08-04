using System.Data;
using MySql.Data.MySqlClient;
using EOM_auth;

namespace EOM_stores._contr.workers
{
    class getWorkers
    {
        _ctrlChannel _socket;

        public DataTable getWorkrs()
        {
            
            _socket = new _ctrlChannel();
            MySqlParameter[] zair = new MySqlParameter[9];

            zair[0] = new MySqlParameter("@wId", MySqlDbType.Int16)
            {  Direction = ParameterDirection.Output };

            zair[1] = new MySqlParameter("@wwId", MySqlDbType.Int16)
            { Direction = ParameterDirection.Output };
            
            zair[2] = new MySqlParameter("@wname", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };


            zair[3] = new MySqlParameter("@waddres", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };


            zair[4] = new MySqlParameter("@wsts", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };

            zair[5] = new MySqlParameter("@wslary", MySqlDbType.Double)
            { Direction = ParameterDirection.Output };

            zair[6] = new MySqlParameter("@idtype", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };

            zair[7] = new MySqlParameter("@idno", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };

            zair[8] = new MySqlParameter("@acc_No", MySqlDbType.Int32)
            { Direction = ParameterDirection.Output };

            DataTable _workers = new DataTable();
            _workers = _socket.storeData("getA_Workers", zair);
            _socket.disConnect();
            return _workers;
        }
        
        public DataTable getApcenWorkrs()
        {
            _socket = new _ctrlChannel();
            MySqlParameter[] zair = new MySqlParameter[4];

            zair[0] = new MySqlParameter("@wor_Id", MySqlDbType.Int16)
            { Direction = ParameterDirection.Output };

            zair[1] = new MySqlParameter("@fullName", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };

            zair[2] = new MySqlParameter("@phone_no", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };


            zair[3] = new MySqlParameter("@hosId", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };
            
            DataTable _workers = new DataTable();
            _workers = _socket.storeData("workerCheck", zair);
            _socket.disConnect();
            return _workers;
        }

    }
}
