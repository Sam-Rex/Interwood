using System;
using System.Data;
using MySql.Data.MySqlClient;
using EOM_auth;
namespace EOM_stores._contr.imports
{
    class getImporters
    {
        _ctrlChannel _socket;

       public DataTable getImp4edit()
        {
            _socket = new _ctrlChannel();

            MySqlParameter[] zair = new MySqlParameter[7];

            
            zair[0] = new MySqlParameter("@iimpId", MySqlDbType.Int32)
            { Direction = ParameterDirection.Output };

            zair[1] = new MySqlParameter("@ifullName", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };

            zair[2] = new MySqlParameter("@iphoneNo", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };

            zair[3] = new MySqlParameter("@iaddress", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };

            zair[4] = new MySqlParameter("@ieMail", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };
            
            zair[5] = new MySqlParameter("@iimpStatus", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };

            zair[6] = new MySqlParameter("@iIdentifyNo", MySqlDbType.Int32)
            { Direction = ParameterDirection.Output };

            DataTable dt = new DataTable();
            dt = _socket.storeData("getA_Importers", zair);
            return dt;
        }
    }
}
