using System;
using MySql.Data.MySqlClient;
using System.Data;


namespace EOM_auth
{
    public class _ctrlChannel
    {

        private const String _SERVER = "127.0.0.1";
        private const String _DATABASE = "dbsinterwood";
        private const String _PASSWORD = "0965649623interwood2019@";
        private const String _UID = "interwood_eg_13219";
        public static MySqlConnection dbcon;
        private string Vodka { get; set;}
        public static void InitializeDb()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = _SERVER;
            builder.Database = _DATABASE;
            builder.UserID = _UID;
            builder.Password =  _PASSWORD;
            builder.Port = Convert.ToUInt32("3306");
            string connStr = builder.ToString();
            builder = null;
            dbcon = new MySqlConnection(connStr);

        }

        public void connect()
        {  
            if (dbcon.State != ConnectionState.Open)
            {
                dbcon.Open();
            }
            else { dbcon.Close(); dbcon.Open(); }
        }

        public void disConnect()
        {

            if (dbcon.State != ConnectionState.Closed)
            {
                dbcon.Close();
            }

        }

        public DataTable getCities()
        {
            // return customers with id and the full name  
            MySqlParameter[] ds = new MySqlParameter[2];
            ds[0] = new MySqlParameter("@cityIde", MySqlDbType.Int16)
            { Direction = ParameterDirection.Output };

            ds[1] = new MySqlParameter("@cityNamee", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };

            DataTable _allCities = new DataTable();
            _allCities= storeData("getCities", ds);
            disConnect();
            return _allCities;
        }

        public DataTable getCountries()
        {
            // return customers with id and the full name  
            MySqlParameter[] ds = new MySqlParameter[2];
            ds[0] = new MySqlParameter("@contryId", MySqlDbType.Int16)
            { Direction = ParameterDirection.Output };

            ds[1] = new MySqlParameter("@contryName", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };


            DataTable _allCountries= new DataTable();
            _allCountries = storeData("getCountries", ds);
            disConnect();
            return _allCountries;
        }


        public DataTable getId_type()
        {
            // return customers with id and the full name  
            MySqlParameter[] ds = new MySqlParameter[2];
            ds[0] = new MySqlParameter("@typeId", MySqlDbType.Int16)
            { Direction = ParameterDirection.Output };

            ds[1] = new MySqlParameter("@typeLabel", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };


            DataTable _types = new DataTable();
            _types = storeData("getIdTypes", ds);
            disConnect();
            return _types;
        }

        public DataTable getJobs()
        {
        

            MySqlParameter[] ds = new MySqlParameter[2];
            ds[0] = new MySqlParameter("@jjobsId", MySqlDbType.Int32)
            { Direction = ParameterDirection.Output };

            ds[1] = new MySqlParameter("@jjobTitle", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };

            DataTable _jobs = new DataTable();
            _jobs = storeData("getJobs", ds);
            disConnect();
            return _jobs;
        }

        public DataTable getHostels()
        {
            MySqlParameter[] ds = new MySqlParameter[2];
            ds[0] = new MySqlParameter("@hhostId", MySqlDbType.Int32)
            { Direction = ParameterDirection.Output };

            ds[1] = new MySqlParameter("@hhostName", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };

            DataTable _hostels = new DataTable();
            _hostels = storeData("getHostels", ds);
            disConnect();
            return _hostels;
        }


        public DataTable getStatus()
        {
            MySqlParameter[] ds = new MySqlParameter[2];
            ds[0] = new MySqlParameter("@stsId", MySqlDbType.Int32)
            { Direction = ParameterDirection.Output };

            ds[1] = new MySqlParameter("@stsLable", MySqlDbType.VarChar)
            { Direction = ParameterDirection.Output };

            DataTable _status = new DataTable();
            _status = storeData("getStatusWk", ds);
            disConnect();
            return _status;
        }

         
        public DataTable getTargetId(string destrict,string target)
        {
            MySqlParameter[] ds = new MySqlParameter[1];
            ds[0] = new MySqlParameter(destrict, MySqlDbType.Int16)
            {Value=DBNull.Value, Direction = ParameterDirection.Output };
            DataTable pdbContainer = new DataTable();
            pdbContainer = storeData(target, ds);
            return pdbContainer;

        }

        public DataTable storeData(string trChannel, MySqlParameter[] list_OF)
        {
            
                InitializeDb();
                MySqlCommand Transmeter = new MySqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = trChannel,
                    Connection = dbcon
                };
            
                if (list_OF != null)
                {
                    Transmeter.Parameters.AddRange(list_OF);
                }
                
                MySqlDataAdapter massenger = new MySqlDataAdapter(Transmeter);
                DataTable _mainContainer = new DataTable();
                massenger.Fill(_mainContainer);
                disConnect();
                return _mainContainer;
           
        }


        public void Transfare(string _chanPoro, MySqlParameter[] _dataContainer)
        {
            MySqlCommand transmeter = new MySqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = _chanPoro,
                Connection = dbcon
            };
            try { 
            transmeter.Parameters.AddRange(_dataContainer);
            connect();
            transmeter.ExecuteNonQuery();
            disConnect();
            }catch(MySqlException Mse)
            {
                System.Windows.Forms.MessageBox.Show("error" + Mse);
            }

            
        }

    }
}
