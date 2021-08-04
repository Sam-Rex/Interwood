using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using EOM_auth;
using System.Data;
namespace EOM_stores._contr.imports
{
    class _imp
    {
        _ctrlChannel _socket;

        private string _impLtrId, _ifName, _imidNName, _ilName, _iphoneN, _iadress, _ieMail, _itStatus, _ihowit;
        private byte[] _imporPict;
        private int _cityId, _conId, _accId, _identityIdc;

        private string impLtrId { get; set; }
        private string ifName { get; set; }
        private string imidNName { get; set; }
        private string ilName { get; set; }
        private string iphoneN { get; set; }
        private string iadress { get; set; }
        private string iemail { get; set; }
        private string imStatus { get; set; }
        private string howit { get; set; }
        private byte[] imporPict { get; set; }
        private int cityId { get; set; }
        private int conId { get; set; }
        private int accId { get; set; }
        private int identityIdc { get; set; }

        public void prep()
        {
            _impLtrId = impLtrId;
            _ifName = ifName;
            _imidNName = imidNName;
            _ilName = ilName;
            _iphoneN = iphoneN;
            _iadress = iadress;
            _ieMail = iemail;
            _itStatus=imStatus;
            _ihowit = howit;
            _imporPict = imporPict;
            _cityId = cityId;
            _conId = conId;
            _accId = accId;
            _identityIdc = identityIdc;

        }

        public void insImporter(string _impLtrId, string _ifName, string _imidNName, string _ilName, string _iphoneN,
            string _iadress,string  _ieMail,string  _itStatus, byte[] _imporPict,int _cityId,int _conId, string  _ihowit )
        {
            DataTable ft, at = new DataTable();
            Ul.Imports.AImp impf = new Ul.Imports.AImp();
            try { 
            
                ft = _socket.getTargetId("@identityId", "getIdenId");
                _identityIdc = ft.Rows[0].Field<int>("Max(identify)");
            
            }catch(NullReferenceException nex) { MessageBox.Show("حدث خطأ أثناء استرجاع بعض البيانات الرجاء المحاولة لاحقاً",
                "اضافة هوية ",MessageBoxButtons.OK,MessageBoxIcon.Warning); }
            _socket = new _ctrlChannel();
            MySqlParameter[] zair = new MySqlParameter[15];

            zair[0] = new MySqlParameter("@iimpLtrId", MySqlDbType.VarChar)
            { Value = _impLtrId, Direction = ParameterDirection.Input };



            zair[1] = new MySqlParameter("@ifName", MySqlDbType.VarChar)
            { Value = _ifName, Direction = ParameterDirection.Input };

            zair[2] = new MySqlParameter("@imidName", MySqlDbType.VarChar)
            { Value = _imidNName, Direction = ParameterDirection.Input };

            zair[3] = new MySqlParameter("@ilName", MySqlDbType.VarChar)
            { Value = _ilName, Direction = ParameterDirection.Input };


            zair[4] = new MySqlParameter("@iphoneNo", MySqlDbType.VarChar)
            {
                Value = _iphoneN,
                Direction = ParameterDirection.Input
            };

            zair[5] = new MySqlParameter("@iaddress", MySqlDbType.VarChar)
            { Value = _iadress, Direction = ParameterDirection.Input };

            zair[6] = new MySqlParameter("@ieMail", MySqlDbType.VarChar)
            { Value = _ieMail, Direction = ParameterDirection.Input };

            zair[7] = new MySqlParameter("@iimpStatus", MySqlDbType.VarChar)
            { Value = _itStatus, Direction = ParameterDirection.Input };

            if(impf.iPicture.Image == null)
            {
                zair[8] = new MySqlParameter("@iimpPict", MySqlDbType.LongBlob)
                { Value =DBNull.Value, Direction = ParameterDirection.Input };
            }
            else
            {
                zair[8] = new MySqlParameter("@iimpPict", MySqlDbType.LongBlob)
                { Value = _imporPict, Direction = ParameterDirection.Input };
            }
            


            zair[9] = new MySqlParameter("@iCityId", MySqlDbType.Int16)
            { Value = _cityId, Direction = ParameterDirection.Input };

            

            zair[10] = new MySqlParameter("@iConId", MySqlDbType.Int32)
            { Value = _conId, Direction = ParameterDirection.Input };

          
             zair[11] = new MySqlParameter("@iaccId", MySqlDbType.Int32)
                {
                    Value =DBNull.Value,
                    Direction = ParameterDirection.Input
             };
                
    
             zair[12] = new MySqlParameter("@iidenId", MySqlDbType.Int32)
             { Value = _identityIdc, Direction = ParameterDirection.Input };

           
            zair[13] = new MySqlParameter("@hoit", MySqlDbType.VarChar)
            { Value = _ihowit, Direction = ParameterDirection.Input };


            zair[14] = new MySqlParameter("@iimpId", MySqlDbType.Int32)
            { Value = DBNull.Value, Direction = ParameterDirection.Output };

            _socket.connect();
            _socket.Transfare("addNewImporter", zair);
            _socket.disConnect();
        }

        //iimpId int (5),iFullName varchar(60),iphoneNo varchar(15),iaddress varchar(35),ieMail

        public DataTable  pursh_Importers()
        {
            _socket = new _ctrlChannel();

            MySqlParameter[] zair = new MySqlParameter[5]; 

            zair[0] = new MySqlParameter("@iimpId", MySqlDbType.Int32)
            {Direction = ParameterDirection.Output };
            
            zair[1] = new MySqlParameter("@iFullName", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };

            zair[2] = new MySqlParameter("@iphoneNo", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output};


            zair[3] = new MySqlParameter("@ieMail", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };

            zair[4] = new MySqlParameter("@iaccount", MySqlDbType.Int32)
            { Direction = ParameterDirection.Output };

            DataTable dt = new DataTable();
            dt = _socket.storeData("purshImporter", zair);
            _socket.disConnect();
            return dt;
        }
    }
}
