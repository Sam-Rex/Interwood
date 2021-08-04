using System.Data;
using MySql.Data.MySqlClient;
using EOM_auth;

namespace EOM_stores._contr.Saling
{
    class get_Orders
    {
        _ctrlChannel _socket;

        public DataTable getAllOrders(int _orderId)
        {
            _socket = new _ctrlChannel();
            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("@sOrder_id", MySqlDbType.Int32)
            { Value = _orderId, Direction = ParameterDirection.Input };
            DataTable _orders = new DataTable();
            _orders = _socket.storeData("getA_Orders", param);
            _socket.disConnect();
            return _orders;
        }

         
        public DataTable getOrderDetails(int _reciveOrderId)
        {
            _socket = new _ctrlChannel();

            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("_order_Id", MySqlDbType.Int32)
            { Value = _reciveOrderId, Direction = ParameterDirection.Input };
            DataTable _reciveOrders = new DataTable();
            _reciveOrders = _socket.storeData("getOrderDetails", param);
            _socket.disConnect();
            return _reciveOrders;
        }

        public DataTable getOrderDetails4Print(int _orderId,string _company_Name,string _recipt)
        {
            _socket = new _ctrlChannel();

            MySqlParameter[] zair= new MySqlParameter[3];
            zair[0] = new MySqlParameter("@_order_Id", MySqlDbType.Int32)
            { Value = _orderId, Direction = ParameterDirection.Input };
            
            zair[1] = new MySqlParameter("@_companyName", MySqlDbType.VarChar)
            { Value = _company_Name, Direction = ParameterDirection.Input };

            zair[2] = new MySqlParameter("@_recipt", MySqlDbType.VarChar)
            { Value = _recipt, Direction = ParameterDirection.Input };

            DataTable _detOrders = new DataTable();
            _detOrders = _socket.storeData("orderDetails4Print", zair);
            _socket.disConnect();
            return _detOrders;
        }
    }
}
