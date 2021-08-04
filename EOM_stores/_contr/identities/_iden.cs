using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using EOM_auth;
namespace EOM_stores._contr.identities
{
    class _iden
    {
        private  _ctrlChannel _socket;
        private string _idenNoIi;
        private string  _idLetterIdIi;
        private int _idenTypeIi;
        private string _birthDateIi;
        private string _releaseDateIi;
        private string _expiryDateIi;
        private string _IssuerIi;
        private string _issuingPlai;
        private string _hoiti;
        private int _identVerifyi;
        private byte[] _idPhotoi;
        private int identVerifyi { get; set; }


        private string idenN { get; set; }
        private string idLetterI { get; set; }
        private int idenTyp { get; set; }
        private string birthDat { get; set; }
        private string releaseDat { get; set; }
        private string expiryDat { get; set; }
        private string Issue { get; set; }
        private string issuingP { get; set; }
        private byte[] idPho { get; set; }
        private string ho { get; set; }
        private int identVer { get; set; }


        private void config ()
        {
            _identVerifyi = identVerifyi;
            _idenNoIi = idenN;
            _idLetterIdIi = idLetterI;
            _idenTypeIi = idenTyp;
            _birthDateIi = birthDat;
            _releaseDateIi = releaseDat;
            _expiryDateIi = expiryDat;
            _IssuerIi = Issue;
            _issuingPlai = issuingP;
            _idPhotoi = idPho;
            _hoiti = ho; 
        }

        /// <summary>
        /// This method is working as a getter to get data from the view about inserting ideintity then deliver it 
        /// to data access layer to insert new row in database then return thae last insert id value the parameter hoit
        /// to checl the insert statement is with photo or not ... 
        /// </summary>
        /// <param name="_idenNoIi"></param>
        /// <param name="_idLetterIdIi"></param>
        /// <param name="_idenTypeIi"></param>
        /// <param name="_birthDateIi"></param>
        /// <param name="_releaseDateIi"></param>
        /// <param name="_expiryDateIi"></param>
        /// <param name="_IssuerIi"></param>
        /// <param name="_issuingPlai"></param>
        /// <param name="_idPhotoi"></param>
        /// <param name="_hoiti"></param>
        /// <param name="_identVerify"></param>
        public void insertIdentity(string _idenNoIi, string _idLetterIdIi, int _idenTypeIi, string _birthDateIi,
            string _releaseDateIi, string _expiryDateIi, string _IssuerIi, string _issuingPlai ,byte[] _idPhotoi,string _hoiti)
        {   try
            {
                _socket = new _ctrlChannel();

                MySqlParameter[] zair = new MySqlParameter[11];


                zair[0] = new MySqlParameter("@idenNoI", MySqlDbType.VarChar)
                {
                    Value = _idenNoIi,
                    Direction = ParameterDirection.Input
                };

                zair[1] = new MySqlParameter("@IdLettreIdI", MySqlDbType.VarChar)
                {
                    Value = _idLetterIdIi,
                    Direction = ParameterDirection.Input
                };

                zair[2] = new MySqlParameter("@IdenTypes", MySqlDbType.Int32)
                {
                    Value = _idenTypeIi,
                    Direction = ParameterDirection.Input
                };

                zair[3] = new MySqlParameter("@birthDateI", MySqlDbType.String)//all date variables must be handele to Mysql Date Format
                {
                    Value = _birthDateIi,
                    Direction = ParameterDirection.Input
                };

                zair[4] = new MySqlParameter("@releaseDateI", MySqlDbType.String)
                {
                    Value = _releaseDateIi,
                    Direction = ParameterDirection.Input
                };

                zair[5] = new MySqlParameter("@expiryDateI", MySqlDbType.String)
                {
                    Value = _expiryDateIi,
                    Direction = ParameterDirection.Input
                };

                zair[6] = new MySqlParameter("@IssuerI", MySqlDbType.VarChar)
                {
                    Value = _IssuerIi,
                    Direction = ParameterDirection.Input
                };

                zair[7] = new MySqlParameter("@issuingPla", MySqlDbType.VarChar)
                {
                    Value = _issuingPlai,
                    Direction = ParameterDirection.Input
                };

                zair[8] = new MySqlParameter("@idPhotos", MySqlDbType.LongBlob)
                {
                    Value = _idPhotoi,
                    Direction = ParameterDirection.Input
                };

                zair[9] = new MySqlParameter("@hoit", MySqlDbType.VarChar)
                {
                    Value = _hoiti,
                    Direction = ParameterDirection.Input
                };


                zair[10] = new MySqlParameter("@ident", MySqlDbType.Int32)
                {
                    Direction = ParameterDirection.Output,
                    Value = DBNull.Value
                };
                
                _socket.connect();
                _socket.Transfare("addIdentity", zair);
                _socket.disConnect();
            }
            catch (MySql.Data.MySqlClient.MySqlException we) { MessageBox.Show("error" + we); }
        }


        /// <summary>
        /// This method is working as a getter and setter to get data from the view to begin update process of ideintity then deliver it 
        /// to data access layer to to update the selected row from data gride or any kind of viewing elemnts then return the last insert id value
        /// the parameter hoit to check the update statement is with a picture  or with-out ... 
        /// </summary>
        /// <param name="_identVerify"></param>
        /// <param name="_idenNoI"></param>
        /// <param name="_idLetterIdI"></param>
        /// <param name="_idenTypeI"></param>
        /// <param name="birthDateI"></param>
        /// <param name="_releaseDateI"></param>
        /// <param name="_expiryDateI"></param>
        /// <param name="_IssuerI"></param>
        /// <param name="_issuingPla"></param>
        /// <param name="_idPhoto"></param>
        /// <param name="_hoit"></param>
        public void updateIdentity(int _identVerifyi, string _idenNoIi, string _idLetterIdIi, int _idenTypeIi, string _birthDateIi,
            string _releaseDateIi, string _expiryDateIi, string _IssuerIi, string _issuingPlai, byte[] _idPhotoi, string _hoiti)
        {
            try
            {
                _socket = new _ctrlChannel();

                MySqlParameter[] zair = new MySqlParameter[11];


                zair[0] = new MySqlParameter("@ident", MySqlDbType.Int32)
                {
                    Direction = ParameterDirection.InputOutput,
                    Value = _identVerifyi
                };

                zair[1] = new MySqlParameter("@idenNoI", MySqlDbType.VarChar)
                {
                    Value = _idenNoIi,
                    Direction = ParameterDirection.Input
                };

                zair[2] = new MySqlParameter("@IdLettreIdI", MySqlDbType.VarChar)
                {
                    Value = _idLetterIdIi,
                    Direction = ParameterDirection.Input
                };

                zair[3] = new MySqlParameter("@IdenTypes", MySqlDbType.Int32)
                {
                    Value = _idenTypeIi,
                    Direction = ParameterDirection.Input
                };

                zair[4] = new MySqlParameter("@birthDateI", MySqlDbType.String)//all date variables must be handele to Mysql Date Format
                {
                    Value = _birthDateIi,
                    Direction = ParameterDirection.Input
                };

                zair[5] = new MySqlParameter("@releaseDateI", MySqlDbType.String)
                {
                    Value = _releaseDateIi,
                    Direction = ParameterDirection.Input
                };

                zair[6] = new MySqlParameter("@expiryDateI", MySqlDbType.String)
                {
                    Value = _expiryDateIi,
                    Direction = ParameterDirection.Input
                };

                zair[7] = new MySqlParameter("@IssuerI", MySqlDbType.VarChar)
                {
                    Value = _IssuerIi,
                    Direction = ParameterDirection.Input
                };

                zair[8] = new MySqlParameter("@issuingPla", MySqlDbType.VarChar)
                {
                    Value = _issuingPlai,
                    Direction = ParameterDirection.Input
                };

                
                    zair[9] = new MySqlParameter("@idPhotos", MySqlDbType.LongBlob)
                    {
                        Value =_idPhotoi,
                        Direction = ParameterDirection.Input
                    };


                zair[10] = new MySqlParameter("@hoit", MySqlDbType.VarChar)
                {
                    Value = _hoiti,
                    Direction = ParameterDirection.Input
                };

                

                _socket.connect();
                _socket.Transfare("updateIdentity", zair);
                _socket.disConnect();
            }
            catch (MySql.Data.MySqlClient.MySqlException we) { MessageBox.Show("error" + we); }
        }


        /// <summary>
        /// Get the identity Id to verify the row to delete 
        /// </summary>
        /// <param name="_identVerify"></param>
        public void deleteIdentity(int _identVerify)
        {
            try
            {
                _socket = new _ctrlChannel();

                MySqlParameter[] zair = new MySqlParameter[1];

                zair[0] = new MySqlParameter("@identVerify", MySqlDbType.Int32)
                {
                    Direction = ParameterDirection.Input,
                    Value = _identVerify
                };

                _socket.connect();
                _socket.Transfare("deleteIdentity", zair);
                _socket.disConnect();
            }
            catch (MySql.Data.MySqlClient.MySqlException we) { MessageBox.Show("error" + we); }
        }
    }
}