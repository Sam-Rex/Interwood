using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using EOM_auth;
namespace EOM_stores._contr.accounts
{
    class _accCtrl
    {
        _ctrlChannel _socket;
        
        private int _accountType;
        private string _ownerLetterId;
        private int _ownerId;
        private int _accountDirection;
        private int _from2;
        private string _cheqSerialNo;
        private string _acoStatment;
        private double _aaprice;
        private string _issuer;
        private byte[] _acoRefarePhoto;
        private string _operation;

        
        private int accountType { get; set; }
        private string ownerLetterId { get; set; }
        private int ownerId { get; set; }

        private int accountDirection { get; set; }
        private int from2{ get; set; }

        private string cheqSerialNo { get; set; }
        private string acoStatment { get; set; }
        private double aaprice { get; set; }
        private string  issuer { get; set; }
        private byte[]  acoRefarePhoto { get; set; }
        private string operation { get; set; }

        private void deco()
        {
        
            _accountType= accountType;
            _ownerLetterId = ownerLetterId;
            _ownerId = ownerId;
            _accountDirection = accountDirection;
            _from2 = from2;
            _cheqSerialNo= cheqSerialNo;
            _aaprice = aaprice;
            _issuer = issuer;
            _acoRefarePhoto= acoRefarePhoto;
            _acoStatment = acoStatment;
            _operation= operation;
        }



        public void insertNewAcot(int _accountType, string _ownerLetterId, int _ownerId,int _accountDirection, int _from2,
            string _cheqSerialNo,string _acoStatment, double _aaprice, string _issuer, byte[]_acoRefarePhoto ,string _operation, string _howit)
        {
            
            _socket = new _ctrlChannel();
            MySqlParameter[] zair = new MySqlParameter[12];
            
            zair[0] = new MySqlParameter("@aacoType", MySqlDbType.Int32)
            { Value = _accountType, Direction = ParameterDirection.Input };
            
            zair[1] = new MySqlParameter("@ownerLettreId", MySqlDbType.VarChar)
            { Value = _ownerLetterId, Direction = ParameterDirection.Input };

            zair[2] = new MySqlParameter("@ownerId", MySqlDbType.Int32)
            { Value = _ownerId, Direction = ParameterDirection.Input };

            zair[3] = new MySqlParameter("@direction", MySqlDbType.Int32)
            { Value = _accountDirection, Direction = ParameterDirection.Input };


            zair[4] = new MySqlParameter("@userId", MySqlDbType.Int32)
            { Value = Program._usrIden,Direction = ParameterDirection.Input};

            zair[5] = new MySqlParameter("@fromTo", MySqlDbType.Int32)
            { Value = _from2, Direction = ParameterDirection.Input };

            zair[6] = new MySqlParameter("@acheqeSerialNo", MySqlDbType.VarChar)
            {
                Value = _cheqSerialNo,
                Direction = ParameterDirection.Input
            };

            zair[7] = new MySqlParameter("@aacoStatement", MySqlDbType.VarChar)
            {
                Value = _acoStatment,
                Direction = ParameterDirection.Input
            };

            zair[8] = new MySqlParameter("@aprice", MySqlDbType.Double)
            {
                Value = _aaprice,
                Direction = ParameterDirection.Input
            };

            zair[9] = new MySqlParameter("@aacoIssuer", MySqlDbType.VarChar)
            { Value = _issuer, Direction = ParameterDirection.Input };
            
            if(_howit=="w")
            {
                zair[10] = new MySqlParameter("@aaccRefarePhoto", MySqlDbType.LongBlob)
                {
                    Value = _acoRefarePhoto,
                    Direction = ParameterDirection.Input
                };
            }

            else if (_howit == "n")
            {
                zair[10] = new MySqlParameter("@aaccRefarePhoto", MySqlDbType.LongBlob)
                {
                    Value = DBNull.Value,
                    Direction = ParameterDirection.Input
                };
            }




            zair[11] = new MySqlParameter("@operation", MySqlDbType.VarChar)
            {
                Value = _operation,
                Direction = ParameterDirection.Input
            };
            

            _socket.connect();
            _socket.Transfare("insAccounts", zair);
            _socket.disConnect();

        }

        public void updateAccount(int _accountId,int _accountType, string _accountLetterId, int _accountDirection,
            string _cheqSerialNo, string _acoStatment, int _aaprice, string _issuer, byte[] _acoRefarePhoto, string _howit)
        {
            _socket = new _ctrlChannel();
            MySqlParameter[] zair = new MySqlParameter[12];


            zair[0] = new MySqlParameter("@aacotId", MySqlDbType.Int32)
            { Value = _accountId, Direction = ParameterDirection.InputOutput };

            zair[1] = new MySqlParameter("@aacoType", MySqlDbType.Int32)
            { Value = _accountType, Direction = ParameterDirection.Input };

            zair[2] = new MySqlParameter("@aacoLettreId", MySqlDbType.VarChar)
            { Value = _accountLetterId, Direction = ParameterDirection.Input };

            zair[3] = new MySqlParameter("@aacoDirection", MySqlDbType.Int32)
            { Value = _accountDirection, Direction = ParameterDirection.Input };
            
            zair[4] = new MySqlParameter("@acheqeSerialNo", MySqlDbType.VarChar)
            {Value = _cheqSerialNo,Direction = ParameterDirection.Input};

            zair[5] = new MySqlParameter("@aacoStatement", MySqlDbType.VarChar)
            {
                Value = _acoStatment,
                Direction = ParameterDirection.Input
            };

            zair[6] = new MySqlParameter("@aprice", MySqlDbType.Int32)
            {
                Value = _aaprice,
                Direction = ParameterDirection.Input
            };

            zair[7] = new MySqlParameter("@aacoIssuer", MySqlDbType.VarChar)
            { Value = _issuer, Direction = ParameterDirection.Input };

            zair[8] = new MySqlParameter("@aregisterDate", MySqlDbType.String)
            { Value = DateTime.Now.ToShortDateString(), Direction = ParameterDirection.Input };

            zair[9] = new MySqlParameter("@aregisterTime", MySqlDbType.String)
            { Value = DateTime.Now.ToShortTimeString(), Direction = ParameterDirection.Input };


            zair[10] = new MySqlParameter("@aaccRefarePhoto", MySqlDbType.Blob)
            {
                Value = _acoRefarePhoto,
                Direction = ParameterDirection.Input
            };

            zair[11] = new MySqlParameter("@operation", MySqlDbType.VarChar)
            {
                Value = _howit,
                Direction = ParameterDirection.Input
            };


            _socket.connect();
            _socket.Transfare("updateAccounts", zair);
            _socket.disConnect();

        }

        public void deleteAccount(int accountId)
        {
            _socket = new _ctrlChannel();
            MySqlParameter[] zair = new MySqlParameter[1];

            zair[0] = new MySqlParameter("@acotId", MySqlDbType.Int32)
            { Value = accountId, Direction = ParameterDirection.InputOutput };
            
            _socket.connect();
            _socket.Transfare("deleteAccounts", zair);
            _socket.disConnect();

        }
    }
}
