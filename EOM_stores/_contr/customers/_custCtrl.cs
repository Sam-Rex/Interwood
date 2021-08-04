using System;
using System.Data;
using MySql.Data.MySqlClient;
using EOM_auth;
using System.Windows.Forms;
namespace EOM_stores._contr

{
    
    class _custCtrl
    {
       
        
        public static _ctrlChannel _socket = new _ctrlChannel();
        private string _custLtrId, _fName, _midNName, _lName, _phoneN, _adress, _eMail, _tStatus,_howit;
        private byte[] _stPict;
        private int _custId ,_cityId,_conId,_identityIdc;

        private int custId { get; set; }
        private string custLtrId { get; set; }
        private string fName { get; set; }
        private string midNName { get; set; }
        private string lName { get; set; }
        private string phoneN { get; set; }
        private string adress { get; set; }
        private string email { get; set; }
        private string tStatus { get; set; }
        private string howit { get; set; }
        private byte[] stPict{ get; set; }
        private int cityId { get; set; }
        private int conId { get; set; }
        private int identityIdc { get; set; }

        private void preparing()
        {
            _custId = custId;
            _custLtrId = custLtrId;
            _fName = fName;
            _midNName = midNName;
            _lName = lName;
            _phoneN = phoneN;
            _adress = adress;
            _eMail = email;
            _tStatus = tStatus;
            _howit = howit;
            _stPict = stPict;
            _cityId = cityId;
            _conId = conId;
            _identityIdc = identityIdc;

        }

        /// <summary>
        /// this section is a controller to add customer and manuplate data belong to customers 
        /// </summary>
        /// <returns></returns>
        public DataTable getCustomers() {
            // return customers with id and the full name  
            MySqlParameter[] ds = new MySqlParameter[3];
            ds[0] = new MySqlParameter("@custId", MySqlDbType.Int16)
            { Direction = ParameterDirection.Output };

            ds[1] = new MySqlParameter("@firstName", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };

            ds[2] = new MySqlParameter("@midName", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };
            DataTable _allCustomers = new DataTable();
            _allCustomers = _socket.storeData("bringAllCust",ds);
            _socket.disConnect();
            return _allCustomers;    
        }

        // fill combo box account type  
        public DataTable retAcotType()
        {
            MySqlParameter[] rs = new MySqlParameter[2];
            rs[0] = new MySqlParameter("@actypeId", MySqlDbType.Int32)
            { Direction = ParameterDirection.Output };

            rs[1] = new MySqlParameter("@actypeLabel", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };

            DataTable pdbContainer = new DataTable();
            pdbContainer = _socket.storeData("returnHowAcot", rs);
            return pdbContainer;
        }

        public DataTable getDefAco()
        {
            // return account direction if (in || out)  
            MySqlParameter[] ds = new MySqlParameter[2];
            ds[0] = new MySqlParameter("@accNameId", MySqlDbType.Int16)
            { Direction = ParameterDirection.Output };

            ds[1] = new MySqlParameter("@acco_name", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };

            DataTable _allDirection = new DataTable();
            _allDirection = _socket.storeData("getDefaultAcc", ds);
            _socket.disConnect();
            return _allDirection;
        }

        

        //public DataTable getCusttId()
        //{
        //    DataTable pdbContainer = new DataTable();
        //    pdbContainer = _Sin.storeData("custId", "customers");
        //    return pdbContainer;
        //}

        

        public DataTable searchOnCostomers(string _custSearchParameter)
        {
           /*
           * This method 2 search search in customers ...  
           * user interface if equal then we can insert a customer or identity .. 
           */
            MySqlParameter[] Zair = new MySqlParameter[1];
            Zair[0] = new MySqlParameter("@custSearchParameter", MySqlDbType.Int16,5);
            Zair[0].Value = _custSearchParameter;
            DataTable serCustomers = new DataTable();
            serCustomers = _socket.storeData("searchCust", Zair);
            _socket.disConnect();
            return serCustomers;
        }

        /// <summary>
        ///  Do not forget any item from this prameters because every thing depence on it 
        /// </summary>
        /// <param name="_custLtrId"></param>
        /// <param name="_fName"></param>
        /// <param name="_midNName"></param>
        /// <param name="_lName"></param>
        /// <param name="_phoneN"></param>
        /// <param name="_adress"></param>
        /// <param name="_eMail"></param>
        /// <param name="_tStatus"></param>
        /// <param name="_howit"></param>
        /// <param name="_stPict"></param>
        /// <param name="_cityId"></param>
        /// <param name="_conId"></param>
        /// <param name="_accId"></param>
        /// <param name="_identityId"></param>
        public void insertNewCust(string _custLtrId, string _fName ,string _midNName ,string _lName ,string _phoneN ,
            string _adress ,string _eMail ,string _tStatus,byte[] _stPict ,int _cityId ,int _conId  ,string _howit)
        {
            //bring account or identity id if user need , depence on check box on user interface
            DataTable ft, at = new DataTable();
            Ul.customers.ACus custf = new Ul.customers.ACus();
            try
            {
                    ft = _socket.getTargetId("@identityId", "getIdenId");
                    _identityIdc = ft.Rows[0].Field<int>("Max(identify)");
                
              
            }
            catch (NullReferenceException nex)
            {
                MessageBox.Show("حدث خطأ اثناء محاولة اجراء العملية السابقة : تم قطع الاتصال ...",
                "اضافة هوية", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }

            _socket = new _ctrlChannel();
            MySqlParameter[] zair = new MySqlParameter[15];

            zair[0] = new MySqlParameter("@ccustLetterId", MySqlDbType.VarChar)
            { Value = _custLtrId, Direction = ParameterDirection.Input };

            

            zair[1] = new MySqlParameter("@cfName", MySqlDbType.VarChar)
            { Value = _fName, Direction = ParameterDirection.Input };

            zair[2] = new MySqlParameter("@cmidNName", MySqlDbType.VarChar)
            { Value = _midNName, Direction = ParameterDirection.Input };

            zair[3] = new MySqlParameter("@clName", MySqlDbType.VarChar)
            { Value = _lName, Direction = ParameterDirection.Input };


            zair[4] = new MySqlParameter("@cphoneNo", MySqlDbType.VarChar)
            { Value = _phoneN,Direction = ParameterDirection.Input};

            zair[5] = new MySqlParameter("@caddress", MySqlDbType.VarChar)
            { Value = _adress, Direction = ParameterDirection.Input };

            zair[6] = new MySqlParameter("@ceMail", MySqlDbType.VarChar)
            { Value = _eMail, Direction = ParameterDirection.Input };

            zair[7] = new MySqlParameter("@ccustStatus", MySqlDbType.VarChar)
            { Value = _tStatus, Direction = ParameterDirection.Input };

            if(custf.cPicture.Image==null)
            {
                zair[8] = new MySqlParameter("@ccustPict", MySqlDbType.LongBlob)
                { Value = DBNull.Value, Direction = ParameterDirection.Input };
            }

            else
            {
                zair[8] = new MySqlParameter("@ccustPict", MySqlDbType.LongBlob)
                { Value = _stPict, Direction = ParameterDirection.Input };
            }
            

            
            zair[9] = new MySqlParameter("@ccityId", MySqlDbType.Int16)
            { Value = _cityId, Direction = ParameterDirection.Input };


            zair[10] = new MySqlParameter("@cconId", MySqlDbType.Int16)
            { Value = _conId, Direction = ParameterDirection.Input };

        
                zair[11] = new MySqlParameter("@caccId", MySqlDbType.Int16)
                {
                    Value = DBNull.Value,
                    Direction = ParameterDirection.Input
                };
            
            
                zair[12] = new MySqlParameter("@cIdentifyId", MySqlDbType.Int32)
                { Value = _identityIdc, Direction = ParameterDirection.Input };
           

            zair[13] = new MySqlParameter("@hoit", MySqlDbType.VarChar)
            { Value = _howit, Direction = ParameterDirection.Input };


            zair[14] = new MySqlParameter("@ccustId", MySqlDbType.Int32)
            { Value =DBNull.Value, Direction = ParameterDirection.Output };

            _socket.connect();
            _socket.Transfare("addNewCustomer", zair);
            _socket.disConnect();
            
        }

        public void updateCust(int _custId, string _custLtrId, string _fName, string _midNName, string _lName, string _phoneN,
            string _adress, string _eMail, string _tStatus, byte[] _stPict, int _cityId, int _conId,int _accId,int _identityIdc, string _howit)
        {
            _socket = new _ctrlChannel();
            Ul.customers.ACus custf = new Ul.customers.ACus();

            MySqlParameter[] zair = new MySqlParameter[15];

            zair[0] = new MySqlParameter("@ccustId", MySqlDbType.Int32)
            { Value = _custId, Direction = ParameterDirection.InputOutput };

            zair[1] = new MySqlParameter("@ccustLetterId", MySqlDbType.VarChar)
            { Value = _custLtrId, Direction = ParameterDirection.Input };
            
            zair[2] = new MySqlParameter("@cfName", MySqlDbType.VarChar)
            { Value = _fName, Direction = ParameterDirection.Input };

            zair[3] = new MySqlParameter("@cmidNName", MySqlDbType.VarChar)
            { Value = _midNName, Direction = ParameterDirection.Input };

            zair[4] = new MySqlParameter("@clName", MySqlDbType.VarChar)
            { Value = _lName, Direction = ParameterDirection.Input };
            
            zair[5] = new MySqlParameter("@cphoneNo", MySqlDbType.VarChar)
            { Value = _phoneN, Direction = ParameterDirection.Input };

            zair[6] = new MySqlParameter("@caddress", MySqlDbType.VarChar)
            { Value = _adress, Direction = ParameterDirection.Input };

            zair[7] = new MySqlParameter("@ceMail", MySqlDbType.VarChar)
            { Value = _eMail, Direction = ParameterDirection.Input };

            zair[8] = new MySqlParameter("@ccustStatus", MySqlDbType.VarChar)
            { Value = _tStatus, Direction = ParameterDirection.Input };

            if (custf.cPicture.Image == null)
            {
                zair[9] = new MySqlParameter("@ccustPict", MySqlDbType.LongBlob)
                { Value = DBNull.Value, Direction = ParameterDirection.Input };
            }

            else
            {
                zair[9] = new MySqlParameter("@ccustPict", MySqlDbType.LongBlob)
                { Value = _stPict, Direction = ParameterDirection.Input };
            }



            zair[10] = new MySqlParameter("@ccityId", MySqlDbType.Int16)
            { Value = _cityId, Direction = ParameterDirection.Input };


            zair[11] = new MySqlParameter("@cconId", MySqlDbType.Int16)
            { Value = _conId, Direction = ParameterDirection.Input };

           
             zair[12] = new MySqlParameter("@caccId", MySqlDbType.Int16)
                {
                    Value = _accId,
                    Direction = ParameterDirection.Input
             };
           

           


           
                zair[13] = new MySqlParameter("@cIdentifyId", MySqlDbType.Int32)
                { Value = _identityIdc, Direction = ParameterDirection.Input };
            

            zair[14] = new MySqlParameter("@hoit", MySqlDbType.VarChar)
            { Value = _howit, Direction = ParameterDirection.Input };


            
            _socket.connect();
            _socket.Transfare("updateCustomer ", zair);
            _socket.disConnect();

        }



        /// <summary>
        /// this architucture to display aall customers on data gride view ...
        /// </summary>
        /// <returns></returns>
        public DataTable getA_Customers()
        {


            _socket = new _ctrlChannel();
            MySqlParameter[] zair = new MySqlParameter[10];

            
            zair[0] = new MySqlParameter("@ccustId", MySqlDbType.Int32)
            {  Direction = ParameterDirection.Output };
            
            zair[1] = new MySqlParameter("@cfullName", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };

            zair[2] = new MySqlParameter("@cphoneNo", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };

            zair[3] = new MySqlParameter("@caddress", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };


            zair[4] = new MySqlParameter("@ceMail", MySqlDbType.VarChar)
            {Direction = ParameterDirection.Output};

            zair[5] = new MySqlParameter("@ccustStatus", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };

            zair[6] = new MySqlParameter("@caccId", MySqlDbType.Int32)
            { Direction = ParameterDirection.Output };

            zair[7] = new MySqlParameter("@caccPrice", MySqlDbType.Int32)
            { Direction = ParameterDirection.Output };

            zair[8] = new MySqlParameter("@aacoDirection", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };


            zair[9] = new MySqlParameter("@cIdentifyNo", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };
            
            DataTable _allCustomers = new DataTable();

            _allCustomers=_socket.storeData("getA_Customers", zair);

            _socket.disConnect();
            return _allCustomers;



        }

        public void deleteCust(int custId)
        {
            _socket = new _ctrlChannel();
            MySqlParameter[] zair = new MySqlParameter[1];

            zair[0] = new MySqlParameter("@custId", MySqlDbType.Int16,5);
            zair[0].Value = custId;
            
            _socket.connect();
            _socket.Transfare("deleteCostomer", zair);
            _socket.disConnect();


        }

    }
}
