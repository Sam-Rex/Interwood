using System;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data;
using EOM_auth;

namespace EOM_stores._contr.identities
{
    class _getIdens
    {
        _ctrlChannel _socket;
        public DataTable getId4Edit(string _idenNumber)
        {
            _socket = new _ctrlChannel();
            MySqlParameter[] zair = new MySqlParameter[9];

            zair[0] = new MySqlParameter("@ident", MySqlDbType.Int32)
            {Direction = ParameterDirection.Output};

            zair[1] = new MySqlParameter("@idenNoI", MySqlDbType.VarChar)
            { Value = _idenNumber, Direction = ParameterDirection.InputOutput};

            
            zair[2] = new MySqlParameter("@IdenTypes", MySqlDbType.VarChar)
            {Direction = ParameterDirection.Output};

            zair[3] = new MySqlParameter("@birthDateI", MySqlDbType.VarChar)
            {Direction = ParameterDirection.Output};

            zair[4] = new MySqlParameter("@releaseDateI", MySqlDbType.VarChar)
            {Direction = ParameterDirection.Output};

            zair[5] = new MySqlParameter("@expiryDateI", MySqlDbType.VarChar)
            {Direction = ParameterDirection.Output};

            zair[6] = new MySqlParameter("@IssuerI", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output};

            zair[7] = new MySqlParameter("@issuingPla", MySqlDbType.VarChar)
            {Direction = ParameterDirection.Output};

            zair[8] = new MySqlParameter("@idPhotos", MySqlDbType.LongBlob)
            {Direction = ParameterDirection.Output};

            DataTable _identityS = new DataTable();
            _identityS = _socket.storeData("iden4Edit", zair);
            _socket.disConnect();
            return _identityS;
        }
    }
}
