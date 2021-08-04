using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;
using EOM_auth;

namespace EOM_stores._contr.__
{
    class primaryAouth
    {
        public _ctrlChannel _socket ;
      

        public DataTable checkAvUsr(string username, string pwd )
        {
            _socket = new _ctrlChannel();
            
            MySqlParameter[] bo = new MySqlParameter[5];
            bo[0] = new MySqlParameter("@UsrName", MySqlDbType.VarChar,(45))
            {Value = username, Direction = ParameterDirection.Input};

            bo[1] = new MySqlParameter("@passwod", MySqlDbType.VarChar,(60))
            {
                Value = pwd, Direction = ParameterDirection.Input
            };

            bo[2] = new MySqlParameter("@userId", MySqlDbType.Int32)
            { Direction = ParameterDirection.Output };

            bo[3] = new MySqlParameter("@UsrType", MySqlDbType.VarChar, (15))
            {Direction = ParameterDirection.Output };

            bo[4] = new MySqlParameter("@UsrfName", MySqlDbType.VarChar, (45))
            { Direction = ParameterDirection.Output };

            DataTable container = new DataTable();
            container =_socket.storeData("checkAvilability", bo);
            return container;
            

        }

        public void EditHash(string _curHash,string _newHash)
        {
            _socket = new _ctrlChannel();

            MySqlParameter[] bo = new MySqlParameter[3];
            bo[0] = new MySqlParameter("@currHash", MySqlDbType.VarChar)
            { Value = _curHash, Direction = ParameterDirection.Input };

            bo[1] = new MySqlParameter("@NewHash", MySqlDbType.VarChar)
            {
                Value = _newHash,
                Direction = ParameterDirection.Input
            };

            bo[2] = new MySqlParameter("@userId", MySqlDbType.Int32)
            {Value =Program._usrIden, Direction = ParameterDirection.Input};

            _socket.connect();
            _socket.Transfare("editHash", bo);
            _socket.disConnect();

        }
    }
}
