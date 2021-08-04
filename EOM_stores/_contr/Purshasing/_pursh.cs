using System;
using MySql.Data.MySqlClient;
using System.Data;
using EOM_auth;

namespace EOM_stores._contr.Purshasing
{
    class _pursh
    {
        _ctrlChannel _socket;
        private int _cateId; private double _UnPrice,_Uamount,_UtotalAmount;
        private int _pQte; private int _impNoe;
        private string _UsrId; private string _pNotes;


        private int cateIdp { get; set; }
        private double UnPrice { get; set; }
        private double Uamount { get; set; }
        private double UtotalAmount { get; set; }
        private int pQtee { get; set; }
        private int impNoe { get; set; }
        private string UsrId { get; set; }
        private string pNotes { get; set; }
        private void prepare()
        {
            _cateId = cateIdp;
            _UnPrice = UnPrice;
            _pQte = pQtee;
            _impNoe = impNoe;
            _UsrId = UsrId;
            _pNotes = pNotes;
            _Uamount = Uamount;
            _UtotalAmount = UtotalAmount;
        }

        public void savePurshase(string _pNotes, int _impNoe, string _UsrId)
        {
            _socket = new _ctrlChannel();

            MySqlParameter[] zair = new MySqlParameter[6];

            zair[0] = new MySqlParameter("@pTime", MySqlDbType.String)
            { Value = DateTime.Now.ToShortTimeString(), Direction = ParameterDirection.Input };

            zair[1] = new MySqlParameter("@pDate", MySqlDbType.String)
            { Value = DateTime.Now.ToShortDateString(), Direction = ParameterDirection.Input };

            zair[2] = new MySqlParameter("@Pnotes", MySqlDbType.VarChar)
            { Value = _pNotes, Direction = ParameterDirection.Input };

            zair[3] = new MySqlParameter("@impNo", MySqlDbType.Int32)
            { Value = _impNoe, Direction = ParameterDirection.Input };

            zair[4] = new MySqlParameter("@usrId", MySqlDbType.VarChar)
            { Value = _UsrId, Direction = ParameterDirection.Input };

            zair[5] = new MySqlParameter("@pTraffic", MySqlDbType.Int32)
            { Value = DBNull.Value, Direction = ParameterDirection.Output };


            _socket.connect();
            _socket.Transfare("insPursh", zair);
            _socket.disConnect();

        }

        public void savePurshDetails(int _rcoId, int _cateId, double _weightVolum ,double _UnPrice, int _pQte)
        {
            _socket = new _ctrlChannel();

            MySqlParameter[] zair = new MySqlParameter[6];
            // Ul.Operations.recive_order rc = new Ul.Operations.recive_order();
            
            zair[0] = new MySqlParameter("@cateId", MySqlDbType.Int32)
            { Value = _cateId, Direction = ParameterDirection.Input };

            zair[1] = new MySqlParameter("@catQTee", MySqlDbType.Int32)
            { Value = _pQte, Direction = ParameterDirection.Input };

            zair[2] = new MySqlParameter("@purVolWeight", MySqlDbType.Double)
            { Value = _weightVolum, Direction = ParameterDirection.Input };

            zair[3] = new MySqlParameter("@uuPrice", MySqlDbType.Double)
            { Value = _UnPrice, Direction = ParameterDirection.Input };
            
            zair[4] = new MySqlParameter("@rcOId", MySqlDbType.Int32)
            { Value = _rcoId, Direction = ParameterDirection.Input };

            zair[5] = new MySqlParameter("@detaId", MySqlDbType.Int32)
            { Value = DBNull.Value, Direction = ParameterDirection.Output };

            _socket.connect();
            _socket.Transfare("purchDetails", zair);
            _socket.disConnect();

            
        }
    }
}
