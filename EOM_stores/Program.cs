using System;
using System.Windows.Forms;
using EOM_auth;
namespace EOM_stores
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static string _fullUsrName;
        public static int _usrIden;
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Ul.__.bringCust());
            
        }
    }
}
