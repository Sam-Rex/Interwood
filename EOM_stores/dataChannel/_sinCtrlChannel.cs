using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using EOM_auth;
using EOM_stores;
using EOM_stores._contr.__;
using System.Data;

namespace EOM_stores.dataChannel
{
    class _sinCtrlChannel
    {
        private _ctrlChannel ced = new _ctrlChannel();
       
        private string _dedicator { get; set; }
       
        private  string CollectVodka(string ra1,string ra2)
        {
            string ge1, rahoul;
            ge1 = "select Max(";rahoul = ")    from";
            _dedicator = ge1 + ra1 + rahoul + ra2;
            return _dedicator;
        }

        //protected  string CollectVodka(string ra1, string ra2, string ra3, string ra4, string ra5)
        //{
        //    string ge1, rahoul, raina;
        //    ge1 = "select"; rahoul = "from"; raina = "where";
        //    _dedicator = ge1 + ra1 + 
        //    return _dedicator;
        //}
        
        public DataTable storeData(string element,string direction)

        {

            _ctrlChannel.InitializeDb();
            MySqlCommand Transmeter = new MySqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = CollectVodka(element,direction),
                Connection = _ctrlChannel.dbcon
            };
            
            MySqlDataAdapter massenger = new MySqlDataAdapter(Transmeter);
            DataTable _mainContainer = new DataTable();
            massenger.Fill(_mainContainer);
            _ctrlChannel.dbcon.Clone();
            //int xdv = _mainContainer.Rows[0].Field<int>();
            return _mainContainer;
        }
    }
}
