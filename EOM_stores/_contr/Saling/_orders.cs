using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using EOM_auth;

namespace EOM_stores._contr.Saling
{
    class _orders
    {
        
        private int _custoId; private string _desc;
        private string _orderTime; private string _orderDate;
        private int _catUId; private int _catUQte, _or_Qte;
        private double _catUPrice, _caWeiVolum; private double _catAmount;
        private double _catTotal;private int _catDiscound;
        private int _orderId;
        private int custoId { get; set; }
        private string desc { get; set; }
        private string orderTime { get; set; }
        private string orderDate { get; set; }
        private int catUId { get; set; }
        private int catUQte { get; set; }
        private int or_Qte { get; set; }
        private double catUPrice { get; set; }
        private double caWeiVolum { get; set; }
        private double catAmount { get; set; }
        private double catTotal { get; set; }
        private int  catDiscound { get; set; }
        private int  orderId { get; set; }

        private void prepare()
        {
            _custoId = custoId;
            _desc = desc;
            _orderTime = orderTime;
            _orderDate = orderDate;

            _catUId = catUId;
            _catUQte = catUQte;
            _or_Qte = or_Qte;
            _catUPrice = catUPrice;
            _caWeiVolum = caWeiVolum;
            _catAmount = catAmount;
            _catTotal = catTotal;
            _catDiscound = catDiscound;
            _orderId = orderId;
        }

    

         private _ctrlChannel _socket;

        /// <summary>
        /// section to getcustomer id an employee details about this invoce from interface and send this parameters to server 
        /// </summary>
        /// <param name="_custoId"></param>
        /// <param name="_desc"></param>
        public void insOrder(int _custoId, string _desc)
        {
            _socket = new _ctrlChannel();

            MySqlParameter[] param = new MySqlParameter[6];
            
            param[0] = new MySqlParameter("@custId", MySqlDbType.Int32)
            { Value = _custoId, Direction = ParameterDirection.Input };

            param[1] = new MySqlParameter("@desNote", MySqlDbType.VarChar)
            { Value = _desc, Direction = ParameterDirection.Input };

            param[2] = new MySqlParameter("@oTime", MySqlDbType.VarChar)
            { Value = DateTime.Now.ToShortTimeString(), Direction = ParameterDirection.Input };

            param[3] = new MySqlParameter("@oDate", MySqlDbType.VarChar)
            { Value = DateTime.Now.ToShortDateString(), Direction = ParameterDirection.Input };

            param[4] = new MySqlParameter("@salesman", MySqlDbType.Int32)
            { Value = Program._usrIden, Direction = ParameterDirection.Input };

            param[5] = new MySqlParameter("@salTrfcId", MySqlDbType.Int32)
            { Value = DBNull.Value, Direction = ParameterDirection.Output };

            _socket.connect();
            _socket.Transfare("insOrder", param);
            _socket.disConnect();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="_produId"></param>
        /// <param name="_proQte"></param>
        /// <param name="_prUPrice"></param>
        /// <param name="_prdAmount"></param>
        /// <param name="_prdTotal"></param>
        /// <param name="_prdDiscound"></param>
        /// <param name="_orderId"></param>
        public void insOrder_details(int _catUId, int _catQte,int _or_Qte,double _catUPrice,double _catAmount,double _catTotal,
            int _catDiscound,double _caWeiVolum, int _orderId)
        {
            /*categoryId int(5),catQte int (5),catWeightVolum double(5,2),order_Qte int (5),
            catUPrice double(8,2),pdAmount double(8,2),pdtotalAmount double(10,2),pddiscound int(3),
            rd_orderId int(7),out detailsId int(5) */
            _socket = new _ctrlChannel();

            MySqlParameter[] param = new MySqlParameter[10];

            param[0] = new MySqlParameter("@categoryId", MySqlDbType.Int32)
            { Value = _catUId, Direction = ParameterDirection.Input };

            param[1] = new MySqlParameter("@catQte", MySqlDbType.Int32)
            { Value = _catQte, Direction = ParameterDirection.Input };

            param[2] = new MySqlParameter("@catWeightVolum", MySqlDbType.Double)
            { Value = _caWeiVolum, Direction = ParameterDirection.Input };

            param[3] = new MySqlParameter("@order_Qte", MySqlDbType.Int32)
            { Value = _or_Qte, Direction = ParameterDirection.Input };


            param[4] = new MySqlParameter("@catUPrice", MySqlDbType.Double)
            { Value = _catUPrice, Direction = ParameterDirection.Input };

            param[5] = new MySqlParameter("@pdAmount", MySqlDbType.Double)
            { Value = _catAmount, Direction = ParameterDirection.Input };

            param[6] = new MySqlParameter("@pdtotalAmount", MySqlDbType.Double)
            { Value = _catTotal, Direction = ParameterDirection.Input };

            param[7] = new MySqlParameter("@pddiscound", MySqlDbType.Int32)
            { Value = _catDiscound, Direction = ParameterDirection.Input };

            param[8] = new MySqlParameter("@rd_orderId", MySqlDbType.Int32)
            { Value = _orderId, Direction = ParameterDirection.Input };

            param[9] = new MySqlParameter("@detailsId", MySqlDbType.Int32)
            { Value = DBNull.Value, Direction = ParameterDirection.Output };

            
            _socket.connect();
            _socket.Transfare("insOrder_Details", param);
            _socket.disConnect();
        }


        
    }
}
