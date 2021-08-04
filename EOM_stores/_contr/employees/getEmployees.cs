using System;
using System.Data;
using MySql.Data.MySqlClient;
using EOM_auth;

namespace EOM_stores._contr.employees
{
    class getEmployees
    {
        _ctrlChannel _socket;
       public DataTable getA_employee()
        {
            _socket = new _ctrlChannel();
            DataTable _workers = new DataTable();
            _workers = _socket.storeData("getA_emploees", null);
            _socket.disConnect();
            return _workers;
        }
    }
}
