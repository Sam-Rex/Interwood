using System;
using MySql.Data.MySqlClient;
using System.Data;
using EOM_auth;
using EOM_stores;
namespace EOM_stores._contr.products
{
    
    class _prdc
    {
        _ctrlChannel _socket;

        private double _totalCosting;private int _categId;
       
        private int _wooPrice, _prdId; private int _prdQte;
        private double _prdDiam;private double _prdCube;
        private int _prdUPrice;private int _prdQuality;
        private int _prdInstall; private int _prdPrepare;
        private int _prdTransport;private int _prdSteels;
        private int _prdRent;



        private double totalCosting { get; set; }
        private int prdId { get; set; }
        private int wooPrice { get; set; }
        private int categId { get; set; }
        private string prdName { get; set; }
        private int prdQte { get; set; }
        private double prdDiam { get; set; }
        private double prdCube { get; set; }
        private int prdUPrice { get; set; }
        private int prdQuality { get; set; }
        private int prdInstall { get; set; }
        private int prdPrepare { get; set; }
        private int prdTransport { get; set; }
        private int prdSteels { get; set; }
        private int prdRent { get; set; }


        private void prep()
        {
            _totalCosting = totalCosting;
            _categId= categId;
            _wooPrice = wooPrice;
            _prdQte = prdQte;
            _prdDiam= prdDiam;
            _prdCube= prdCube;
            _prdUPrice= prdUPrice; 
            _prdQuality= prdQuality;
            _prdInstall = prdInstall;
            _prdPrepare= prdPrepare;
            _prdTransport= prdTransport;
            _prdSteels= prdSteels;
            _prdRent= prdRent; 
        }

        /*
         string _prdLterId,string _prdName,
             */
        public void insProduct(int _categId,int _wooPrice,int _prdQte,double _prdDiam,
            double _prdCube,int _prdUPrice,int _prdQuality,int _prdInstall,int _prdPrepare,int _prdTransport,
            int _prdSteels,int _prdRent)
        {

            try
            {
                _socket = new _ctrlChannel();
                MySqlParameter[] pZair = new MySqlParameter[14];

               

                
                pZair[0] = new MySqlParameter("@pid_cat", MySqlDbType.Int32)
                {
                    Value = _categId,
                    Direction = ParameterDirection.Input
                };

                pZair[1] = new MySqlParameter("@wodPrice", MySqlDbType.Int32)
                {
                    Value = _wooPrice,
                    Direction = ParameterDirection.Input
                };

                pZair[2] = new MySqlParameter("@pQuantity", MySqlDbType.Int32)
                {
                    Value = _prdQte,
                    Direction = ParameterDirection.Input
                };

                pZair[3] = new MySqlParameter("@pDiameter", MySqlDbType.Double)
                {
                    Value = _prdDiam,
                    Direction = ParameterDirection.Input
                };

                pZair[4] = new MySqlParameter("@pcupes", MySqlDbType.Double)
                {
                    Value = _prdCube,
                    Direction = ParameterDirection.Input
                };


                pZair[5] = new MySqlParameter("@pprice", MySqlDbType.Int32)
                {
                    Value = _prdUPrice,
                    Direction = ParameterDirection.Input
                };

                pZair[6] = new MySqlParameter("@pQuality", MySqlDbType.Int32)
                {
                    Value = _prdQuality,
                    Direction = ParameterDirection.Input
                };

                pZair[7] = new MySqlParameter("@pinstall", MySqlDbType.Int32)
                {
                    Value = _prdInstall,
                    Direction = ParameterDirection.Input
                };

                pZair[8] = new MySqlParameter("@pPrepare", MySqlDbType.Int32)
                {
                    Value = _prdPrepare,
                    Direction = ParameterDirection.Input
                };

                pZair[9] = new MySqlParameter("@pTransport", MySqlDbType.Int32)
                {
                    Value = _prdTransport,
                    Direction = ParameterDirection.Input
                };

                pZair[10] = new MySqlParameter("@pSteels", MySqlDbType.Int32)
                {
                    Value = _prdSteels,
                    Direction = ParameterDirection.Input
                };

                pZair[11] = new MySqlParameter("@Prent", MySqlDbType.Int32)
                {
                    Value = _prdRent,
                    Direction = ParameterDirection.Input
                };

              _totalCosting = _wooPrice + _prdInstall + _prdPrepare + _prdTransport + _prdSteels + _prdRent;

                pZair[12] = new MySqlParameter("@pTotCost", MySqlDbType.Int32)
                {
                    Value = _totalCosting,
                    Direction = ParameterDirection.Input
                };

                pZair[13] = new MySqlParameter("@pproId", MySqlDbType.Int32)
                {
                    Value = DBNull.Value,
                    Direction = ParameterDirection.Output
                };

                _socket.connect();
                _socket.Transfare("addNewProduct", pZair);
                _socket.disConnect();
            }catch(MySqlException ex) { System.Windows.Forms.MessageBox.Show("er" + ex); }
        }



        public void updProduct(int _prdId ,int _categId, int _wooPrice, int _prdQte, double _prdDiam,
           double _prdCube, int _prdUPrice, int _prdQuality, int _prdInstall, int _prdPrepare, int _prdTransport,
           int _prdSteels, int _prdRent)
        {

            try
            {
                _socket = new _ctrlChannel();
                MySqlParameter[] pZair = new MySqlParameter[14];
                
                pZair[0] = new MySqlParameter("@pproId", MySqlDbType.Int32)
                {
                    Value = _prdId,
                    Direction = ParameterDirection.InputOutput
                };

                pZair[1] = new MySqlParameter("@pid_cat", MySqlDbType.Int32)
                {
                    Value = _categId,
                    Direction = ParameterDirection.Input
                };

                pZair[2] = new MySqlParameter("@wodPrice", MySqlDbType.Int32)
                {
                    Value = _wooPrice,
                    Direction = ParameterDirection.Input
                };

                pZair[3] = new MySqlParameter("@pQuantity", MySqlDbType.Int32)
                {
                    Value = _prdQte,
                    Direction = ParameterDirection.Input
                };

                pZair[4] = new MySqlParameter("@pDiameter", MySqlDbType.Double)
                {
                    Value = _prdDiam,
                    Direction = ParameterDirection.Input
                };

                pZair[5] = new MySqlParameter("@pcupes", MySqlDbType.Double)
                {
                    Value = _prdCube,
                    Direction = ParameterDirection.Input
                };


                pZair[6] = new MySqlParameter("@pprice", MySqlDbType.Int32)
                {
                    Value = _prdUPrice,
                    Direction = ParameterDirection.Input
                };

                pZair[7] = new MySqlParameter("@pQuality", MySqlDbType.Int32)
                {
                    Value = _prdQuality,
                    Direction = ParameterDirection.Input
                };

                pZair[8] = new MySqlParameter("@pinstall", MySqlDbType.Int32)
                {
                    Value = _prdInstall,
                    Direction = ParameterDirection.Input
                };

                pZair[9] = new MySqlParameter("@pPrepare", MySqlDbType.Int32)
                {
                    Value = _prdPrepare,
                    Direction = ParameterDirection.Input
                };

                pZair[10] = new MySqlParameter("@pTransport", MySqlDbType.Int32)
                {
                    Value = _prdTransport,
                    Direction = ParameterDirection.Input
                };

                pZair[11] = new MySqlParameter("@pSteels", MySqlDbType.Int32)
                {
                    Value = _prdSteels,
                    Direction = ParameterDirection.Input
                };

                pZair[12] = new MySqlParameter("@Prent", MySqlDbType.Int32)
                {
                    Value = _prdRent,
                    Direction = ParameterDirection.Input
                };

                _totalCosting = _wooPrice + _prdInstall + _prdPrepare + _prdTransport + _prdSteels + _prdRent;

                pZair[13] = new MySqlParameter("@pTotCost", MySqlDbType.Int32)
                {
                    Value = _totalCosting,
                    Direction = ParameterDirection.Input
                };

                

                _socket.connect();
                _socket.Transfare("updateProduct", pZair);
                _socket.disConnect();
            }
            catch (MySqlException ex) { System.Windows.Forms.MessageBox.Show("er" + ex); }
        }



        public DataTable displayProducts()
        {
                _socket = new _ctrlChannel();
                MySqlParameter[] pZair = new MySqlParameter[15];
            
                pZair[0] = new MySqlParameter("@pproId", MySqlDbType.Int32)
                {Direction = ParameterDirection.Output};

                pZair[1] = new MySqlParameter("@pid_cat", MySqlDbType.Int32)
                {Direction = ParameterDirection.Output};

                pZair[2] = new MySqlParameter("@wodPrice", MySqlDbType.Int32)
                {Direction = ParameterDirection.Output };

                pZair[3] = new MySqlParameter("@pQuantity", MySqlDbType.Int32)
                {Direction = ParameterDirection.Output };

                pZair[4] = new MySqlParameter("@pDiameter", MySqlDbType.Double)
                {Direction = ParameterDirection.Output };

                pZair[5] = new MySqlParameter("@pcupes", MySqlDbType.Double)
                {Direction = ParameterDirection.Output };


                pZair[6] = new MySqlParameter("@pprice", MySqlDbType.Int32)
                {Direction = ParameterDirection.Output };

                pZair[7] = new MySqlParameter("@pQuality", MySqlDbType.Int32)
                {Direction = ParameterDirection.Output };

                pZair[8] = new MySqlParameter("@pinstall", MySqlDbType.Int32)
                {Direction = ParameterDirection.Output };

                pZair[9] = new MySqlParameter("@pPrepare", MySqlDbType.Int32)
                {Direction = ParameterDirection.Output };

                pZair[10] = new MySqlParameter("@pTransport", MySqlDbType.Int32)
                {Direction = ParameterDirection.Output};

                pZair[11] = new MySqlParameter("@pSteels", MySqlDbType.Int32)
                {Direction = ParameterDirection.Output };

                pZair[12] = new MySqlParameter("@Prent", MySqlDbType.Int32)
                {Direction = ParameterDirection.Output };

            
                pZair[13] = new MySqlParameter("@pTotfoallCost", MySqlDbType.Int32)
                {Direction = ParameterDirection.Output};

                pZair[14] = new MySqlParameter("@pTotCost", MySqlDbType.Int32)
                { Direction = ParameterDirection.Output };

                 DataTable _allProducts = new DataTable();
                
                _allProducts=_socket.storeData("getAProducts", pZair);
                _socket.disConnect();
                return _allProducts;
           
        }

        public DataTable PrintAllProducts(int _costingId)
        {
            _socket = new _ctrlChannel();
            MySqlParameter[] pZair = new MySqlParameter[1];

            pZair[0] = new MySqlParameter("@pro_costing", MySqlDbType.Int32)
            { Value= _costingId, Direction = ParameterDirection.Input };
            
            DataTable _PrintallProducts = new DataTable();

            _PrintallProducts = _socket.storeData("product_costign4_print", pZair);
            _socket.disConnect();
            return _PrintallProducts;

        }

        public DataTable getCats(string _catDrec)
        {
            _socket = new _ctrlChannel();
            MySqlParameter[] par = new MySqlParameter[2];

            par[0] = new MySqlParameter("@catIden", MySqlDbType.Int32)
            { Direction = ParameterDirection.Output };

            par[1] = new MySqlParameter("@catLable", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };

            DataTable _brCat = new DataTable();
            if(_catDrec=="imp")
            {
                _brCat = _socket.storeData("bringCatImp", par);
            }
            else if(_catDrec=="prd")
            {
                _brCat = _socket.storeData("bringCategories", par);
            }
            
            _socket.disConnect();
            return _brCat;
        }

        public DataTable getQul()
        {
            _socket = new _ctrlChannel();
            MySqlParameter[] par = new MySqlParameter[2];

            par[0] = new MySqlParameter("@idQul", MySqlDbType.Int32)
            { Direction = ParameterDirection.Output };

            par[1] = new MySqlParameter("@QulLabel", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };

            DataTable _brCat = new DataTable();
            _brCat = _socket.storeData("getQuality", par);
            _socket.disConnect();
            return _brCat;
        }

    }
}
