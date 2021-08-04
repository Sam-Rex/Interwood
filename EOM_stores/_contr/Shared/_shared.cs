using System;
using System.Data;
using MySql.Data.MySqlClient;
using EOM_auth;
using System.Windows.Forms;
 
namespace EOM_stores._contr.Shared
{
   public class _shared
    {
        public  _ctrlChannel _socket;
        public  DataTable getCities()
        {
            // return customers with id and the full name  
            MySqlParameter[] ds = new MySqlParameter[2];
            ds[0] = new MySqlParameter("@cityIde", MySqlDbType.Int16)
            { Direction = ParameterDirection.Output };

            ds[1] = new MySqlParameter("@cityNamee", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };
            DataTable _allCustomers = new DataTable();
           _socket.storeData("getCities", ds);
           _socket.disConnect();
            return _allCustomers;
        }

       

        string _cityName;
        string _governate;
        int _countryId;
        private string cityName { get; set; }
        private string governate { get; set; }
        private int countryId { get; set; }

        public void prepare()
        {
            _cityName = cityName;
            _governate = governate;
            _countryId = countryId;
        }
        public  void insertCity( string _cityName ,string _governate, int _countryId)
        {
            try
            {
                    _socket = new _ctrlChannel();
                
                    MySqlParameter[] zair = new MySqlParameter[4];


                    zair[0] = new MySqlParameter("@cityNamee", MySqlDbType.VarChar, 45)
                    { Value = _cityName, Direction = ParameterDirection.Input
                    };

                    zair[1] = new MySqlParameter("@bGovernate", MySqlDbType.VarChar)
                    { Value = _governate, Direction = ParameterDirection.Input
                    };

                    zair[2] = new MySqlParameter("@cconId", MySqlDbType.VarChar)
                    { Value = _countryId, Direction = ParameterDirection.Input
                    };

                    zair[3] = new MySqlParameter("@ccityId", MySqlDbType.Int32,5)
                    {  Direction = ParameterDirection.Output,Value=DBNull.Value
                    };
                
                _socket.connect();
                _socket.Transfare("addCity", zair);
                _socket.disConnect();
            }
            catch (MySql.Data.MySqlClient.MySqlException we) { MessageBox.Show("error" + we); }
        }

        public  DataTable getCountries()
        {
            // return customers with id and the full name  
            MySqlParameter[] ds = new MySqlParameter[2];
            ds[0] = new MySqlParameter("@contryId", MySqlDbType.Int16)
            { Direction = ParameterDirection.Output };

            ds[1] = new MySqlParameter("@contryName", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };


            DataTable _allCustomers = new DataTable();
            _allCustomers = _socket.storeData("getCountries", ds);
            _socket.disConnect();
            return _allCustomers;
        }

        /// <summary>
        /// destrict is recive a output parameter of sred procedure and the target is the name of procedure 
        /// </summary>
        /// <param name="destrict"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        
        public string destrict { get; set; }
        public string target { get; set; }
        public  DataTable getTargetId()
        {
            MySqlParameter[] ds = new MySqlParameter[1];
            ds[0] = new MySqlParameter(destrict, MySqlDbType.Int16)
            {Value=DBNull.Value, Direction = ParameterDirection.Output };
            DataTable pdbContainer = new DataTable();
            pdbContainer = _socket.storeData(target, ds);
            return pdbContainer;

        }


    
    }
}
