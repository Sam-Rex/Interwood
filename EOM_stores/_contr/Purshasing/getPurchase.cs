using System;
using EOM_auth;
using System.Data;
using MySql.Data.MySqlClient;

namespace EOM_stores._contr.Purshasing
{
    class getPurchase
    {
        _ctrlChannel _socket;
        public DataTable getAllReciveOrders(int _reciveOrder_id)
        {
            
            _socket = new _ctrlChannel();
            MySqlParameter[] zair = new MySqlParameter[1];
            zair[0] = new MySqlParameter("recive_id", MySqlDbType.Int32)
            { Value = _reciveOrder_id, Direction = ParameterDirection.Input };
            DataTable _reciveOrders = new DataTable();
            _reciveOrders = _socket.storeData("getA_reciveOrder", zair);
            _socket.disConnect();
            return _reciveOrders;
        }

        public DataTable getReciveOrderDetails(int _reciveOrderId)
        {
            _socket = new _ctrlChannel();

            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("recOId", MySqlDbType.Int32)
            { Value = _reciveOrderId, Direction = ParameterDirection.Input };
            DataTable _reciveOrders = new DataTable();
            _reciveOrders = _socket.storeData("getReciveOrderDetails", param);
            _socket.disConnect();
            return _reciveOrders;
        }

        public DataTable perchasePrinting(int _reciveOrder)
        {
            _socket = new _ctrlChannel();

            MySqlParameter[] zair = new MySqlParameter[1];
            /*
            zair[0] = new MySqlParameter("@cmCupePrice", MySqlDbType.Double)
            { Value = _cupeCM, Direction = ParameterDirection.Input };
            */
            zair[0] = new MySqlParameter("@LastOrderId", MySqlDbType.Int32)
            { Value = _reciveOrder, Direction = ParameterDirection.Input };

            DataTable _reciveOrders, _reciveOrdersDetails = new DataTable();
            _reciveOrders = _socket.storeData("reciveOrder4Print", zair);
            _reciveOrdersDetails = _socket.storeData("reciveOrderDetails4Print", zair);

            _reciveOrders.Merge(_reciveOrdersDetails);
            _socket.disConnect();
            return _reciveOrders;
        }


       
    }
}
