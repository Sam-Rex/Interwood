using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Data;
using EOM_auth;

namespace EOM_stores._contr
{

    class _cat
    {
        _ctrlChannel _socket;
        

        private int _catId, _st; private string _catLable;private double _cHieht;
        private double _cWidth; private double _cThickniss,_Volum,_Weight;
        private double _catPrice;private int _catQte;private string _catDesc;

        

        private int catId { get; set; }
        private int st { get; set; }
        private string catLable { get; set; }
        private double cHieht { get; set; }
        private double cWidth { get; set; }
        private double cThickniss { get; set; }
        private double Volum { get; set; }
        private double Weight { get; set; }
        private double catPrice { get; set; }
        private int catQte { get; set; }
        private string catDesc { get; set; }

        private void prepa()
        {
            _catId= catId;
            _st = st;
            _catLable = catLable; 
            _cHieht= cHieht;
            _cWidth= cWidth; 
            _cThickniss= cThickniss; 
            _Volum= Volum;
            _Weight = Weight;
            _catPrice= catPrice; 
            _catQte= catQte;
            _catDesc= catDesc;
        }
        
        
        public void insertNewCat(string _catLable, double _cHieht,double _cWidth,double _cThickniss,double _Volum,double _Weight,
        double _catPrice, int _catQte, string _catDesc)
        {
            _socket = new _ctrlChannel();
            MySqlParameter[] zair = new MySqlParameter[10];
            
            zair[0] = new MySqlParameter("@cctName", MySqlDbType.VarChar)
            { Value = _catLable, Direction = ParameterDirection.Input };

            zair[1] = new MySqlParameter("@cctHeight", MySqlDbType.Double)
            { Value = _cHieht, Direction = ParameterDirection.Input };

            zair[2] = new MySqlParameter("@cctWidth", MySqlDbType.Double)
            { Value = _cWidth, Direction = ParameterDirection.Input };

            zair[3] = new MySqlParameter("@cctThick", MySqlDbType.Double)
            { Value = _cThickniss, Direction = ParameterDirection.Input };

            zair[4] = new MySqlParameter("@ccVolum", MySqlDbType.Double)
            { Value = _Volum, Direction = ParameterDirection.Input };

            zair[5] = new MySqlParameter("@stWeight", MySqlDbType.Double)
            { Value = _Weight, Direction = ParameterDirection.Input };

            zair[6] = new MySqlParameter("@cctDescri", MySqlDbType.VarChar)
            { Value = _catDesc, Direction = ParameterDirection.Input };
            
            zair[7] = new MySqlParameter("@cctPrice", MySqlDbType.Double)
            { Value = _catPrice, Direction = ParameterDirection.Input };

            zair[8] = new MySqlParameter("@cctQte", MySqlDbType.Int32)
            { Value = _catQte, Direction = ParameterDirection.Input };

            zair[9] = new MySqlParameter("@cctCatId", MySqlDbType.Int32)
            { Value = DBNull.Value, Direction = ParameterDirection.Output};

            _socket.connect();
            _socket.Transfare("insCategory", zair);
            _socket.disConnect();
        }


        public void updateCat(int _catId,string _catLable, int _cHieht, int _cWidth, double _cThickniss, 
        double _catPrice, int _catQte, string _catDesc)
        {
            _socket = new _ctrlChannel();
            MySqlParameter[] zair = new MySqlParameter[9];


            zair[0] = new MySqlParameter("@cctCatId", MySqlDbType.Int32)
            { Value = _catId, Direction = ParameterDirection.InputOutput };
            
            zair[1] = new MySqlParameter("@cctHeight", MySqlDbType.Int32)
            { Value = _cHieht, Direction = ParameterDirection.Input };

            zair[2] = new MySqlParameter("@cctWidth", MySqlDbType.Int32)
            { Value = _cWidth, Direction = ParameterDirection.Input };

            zair[3] = new MySqlParameter("@cctThick", MySqlDbType.Double)
            { Value = _cThickniss, Direction = ParameterDirection.Input };

            zair[4] = new MySqlParameter("@ccVolum", MySqlDbType.Double)
            { Value = _Volum, Direction = ParameterDirection.Input };

            zair[5] = new MySqlParameter("@stWeight", MySqlDbType.Double)
            { Value = _Weight, Direction = ParameterDirection.Input };

            zair[6] = new MySqlParameter("@cctDescri", MySqlDbType.VarChar)
            { Value = _catDesc, Direction = ParameterDirection.Input };

            zair[7] = new MySqlParameter("@cctPrice", MySqlDbType.Double)
            { Value = _catPrice, Direction = ParameterDirection.Input };

            zair[8] = new MySqlParameter("@cctQte", MySqlDbType.Int32)
            { Value = _catQte, Direction = ParameterDirection.Input };

            
            _socket.connect();
            _socket.Transfare("updateCategory", zair);
            _socket.disConnect();
        }


        public void deleteCat(int _catId)
        {
            _socket = new _ctrlChannel();
            MySqlParameter[] zair = new MySqlParameter[1];
            
            zair[0] = new MySqlParameter("@cctCatId", MySqlDbType.Int32)
            { Value = _catId, Direction = ParameterDirection.Input};

            _socket.connect();
            _socket.Transfare("deleteCategory", zair);
            _socket.disConnect();
        }
        

        public DataTable displaySt_Categories()
        {
                
                MySqlParameter[] param = new MySqlParameter[9];
            
                param[0] = new MySqlParameter("@cctCatId", MySqlDbType.Int32)
                { Direction = ParameterDirection.Output };

                param[1] = new MySqlParameter("@cctName", MySqlDbType.VarChar)
                { Direction = ParameterDirection.Output };

                param[2] = new MySqlParameter("@cctHeight", MySqlDbType.Int32)
                { Direction = ParameterDirection.Output };

                param[3] = new MySqlParameter("@cctWidth", MySqlDbType.Int32)
                { Direction = ParameterDirection.Output };

                param[4] = new MySqlParameter("@cctThick", MySqlDbType.Double)
                { Direction = ParameterDirection.Output };

                param[5] = new MySqlParameter("@cctVolum", MySqlDbType.Double)
                { Direction = ParameterDirection.Output };

                param[6] = new MySqlParameter("@cctDescri", MySqlDbType.VarChar)
                { Direction = ParameterDirection.Output };

                param[7] = new MySqlParameter("@cctPrice", MySqlDbType.Double)
                { Direction = ParameterDirection.Output };

                param[8] = new MySqlParameter("@cctQte", MySqlDbType.Int32)
                { Direction = ParameterDirection.Output };

                _socket = new _ctrlChannel();
                DataTable _cats = new DataTable();
                _cats.Clear();
                _cats = _socket.storeData("getCategories", param);
                _socket.disConnect();
                return _cats;
        }

        public DataTable displayWo_Categories()
        {

            MySqlParameter[] param = new MySqlParameter[9];

            param[0] = new MySqlParameter("@cctCatId", MySqlDbType.Int32)
            { Direction = ParameterDirection.Output };

            param[1] = new MySqlParameter("@cctName", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };

            param[2] = new MySqlParameter("@cctHeight", MySqlDbType.Int32)
            { Direction = ParameterDirection.Output };

            param[3] = new MySqlParameter("@cctWidth", MySqlDbType.Int32)
            { Direction = ParameterDirection.Output };

            param[4] = new MySqlParameter("@cctThick", MySqlDbType.Double)
            { Direction = ParameterDirection.Output };

            param[5] = new MySqlParameter("@cctVolum", MySqlDbType.Double)
            { Direction = ParameterDirection.Output };

            param[6] = new MySqlParameter("@cctDescri", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };

            param[7] = new MySqlParameter("@cctPrice", MySqlDbType.Double)
            { Direction = ParameterDirection.Output };

            param[8] = new MySqlParameter("@cctQte", MySqlDbType.Int32)
            { Direction = ParameterDirection.Output };

            _socket = new _ctrlChannel();
            DataTable _cats = new DataTable();
            _cats.Clear();
            _cats = _socket.storeData("getCategories1", param);
            _socket.disConnect();
            return _cats;
        }

        
        public DataTable pursh_Cat()
        {
            _socket = new _ctrlChannel();
            MySqlParameter[] zair = new MySqlParameter[5];

            zair[0] = new MySqlParameter("@cctCatId", MySqlDbType.Int32)
            { Direction = ParameterDirection.Output };

            zair[1] = new MySqlParameter("@cctName", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };

            zair[2] = new MySqlParameter("@cctDimentions", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };
            
            zair[3] = new MySqlParameter("@cctThick", MySqlDbType.Double)
            { Direction = ParameterDirection.Output };

            zair[4] = new MySqlParameter("@cctQte", MySqlDbType.Double)
            { Direction = ParameterDirection.Output };

         
            
            DataTable _cats = new DataTable();
            _cats = _socket.storeData("purshCat", zair);
            _socket.disConnect();
            return _cats;

        }

        public DataTable Order_Categories()
        {
            
            _socket = new _ctrlChannel();
            MySqlParameter[] zair = new MySqlParameter[9];

            zair[0] = new MySqlParameter("@cctCatId", MySqlDbType.Int32)
            { Direction = ParameterDirection.Output };

            zair[1] = new MySqlParameter("@cctName", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };

            zair[2] = new MySqlParameter("@cctHeight", MySqlDbType.Int32)
            { Direction = ParameterDirection.Output };

            zair[3] = new MySqlParameter("@cctWidth", MySqlDbType.Int32)
            { Direction = ParameterDirection.Output };

            zair[4] = new MySqlParameter("@cctThick", MySqlDbType.Double)
            { Direction = ParameterDirection.Output };

            zair[5] = new MySqlParameter("@cctVolum", MySqlDbType.Double)
            { Direction = ParameterDirection.Output };

            zair[6] = new MySqlParameter("@cctWeight", MySqlDbType.Double)
            { Direction = ParameterDirection.Output };

            zair[7] = new MySqlParameter("@cctQte", MySqlDbType.Double)
            { Direction = ParameterDirection.Output };

            zair[8] = new MySqlParameter("@cctPrice", MySqlDbType.Double)
            { Direction = ParameterDirection.Output };

            
            DataTable _cats = new DataTable();
            _cats = _socket.storeData("saleCat", zair);
            _socket.disConnect();
            return _cats;

        }


        public void insertNewCost(string _companyName,string _proName,double _proSize ,double _proPrice,int _pCost_id)
        {
            _socket = new _ctrlChannel();
            MySqlParameter[] zair = new MySqlParameter[6];

            zair[0] = new MySqlParameter("@companyName", MySqlDbType.VarChar)
            { Value = _companyName, Direction = ParameterDirection.Input };

            zair[1] = new MySqlParameter("@proName", MySqlDbType.VarChar)
            { Value = _proName, Direction = ParameterDirection.Input };

            zair[2] = new MySqlParameter("@prodSize", MySqlDbType.Double)
            { Value = _proSize, Direction = ParameterDirection.Input };
            
            zair[3] = new MySqlParameter("@prodPrice", MySqlDbType.Double)
            { Value = _proPrice, Direction = ParameterDirection.Input };

            zair[4] = new MySqlParameter("@pCost_id", MySqlDbType.Int32)
            { Value = _pCost_id, Direction = ParameterDirection.Input };

            zair[5] = new MySqlParameter("@usr_id", MySqlDbType.Int32)
            { Value = Program._usrIden, Direction = ParameterDirection.Input };
            

            _socket.connect();
            _socket.Transfare("addNewProductCosting", zair);
            _socket.disConnect();
            
        }

    }
}
