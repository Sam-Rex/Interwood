using System;
using MySql.Data.MySqlClient;
using System.Data;
using EOM_auth;
namespace EOM_stores._contr.customers
{
    class getCust
    {
        _ctrlChannel _socket;

        public DataTable getCust4Edit(int _custId)
        {
            _socket = new _ctrlChannel();

            MySqlParameter[] zair = new MySqlParameter[11];

            zair[0] = new MySqlParameter("@ccustId", MySqlDbType.Int32)
            { Value = _custId, Direction = ParameterDirection.InputOutput };
            

            zair[1] = new MySqlParameter("@cfName", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };

            zair[2] = new MySqlParameter("@cmidNName", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };

            zair[3] = new MySqlParameter("@clName", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };


            zair[4] = new MySqlParameter("@cphoneNo", MySqlDbType.VarChar)
            {Direction = ParameterDirection.Output};

            zair[5] = new MySqlParameter("@caddress", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };

            zair[6] = new MySqlParameter("@ceMail", MySqlDbType.VarChar)
            {  Direction = ParameterDirection.Output };

            zair[7] = new MySqlParameter("@ccustStatus", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };

            zair[8] = new MySqlParameter("@ccustPict", MySqlDbType.LongBlob)
            { Direction = ParameterDirection.Output };


            zair[9] = new MySqlParameter("@ccityName", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };


            zair[10] = new MySqlParameter("@cconName", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };

            

            DataTable _custom = new DataTable();
            _custom = _socket.storeData("cust4Edit", zair);
            _socket.disConnect();
            return _custom;
        }
    }
}
