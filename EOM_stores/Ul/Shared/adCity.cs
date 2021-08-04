using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EOM_stores._contr.Shared;
using EOM_auth;
namespace EOM_stores.Ul
{
    public partial class adCity : Form
    {
        _shared GetShared = new _shared();
        _ctrlChannel _socket = new _ctrlChannel();
        
        string formSection = "addCity";
        
        public adCity()
        {
            InitializeComponent();
            this.TopMost = true;
            if(formSection=="addCity")
            {
                cbCountry.DataSource = _socket.getCountries();
                cbCountry.DisplayMember = "conName";
                cbCountry.ValueMember = "conId";
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                Imports.AImp imp2 = new Imports.AImp();
                customers.ACus acus2 = new customers.ACus();
                GetShared.insertCity(txtCityName.Text,txtGovernate.Text,Convert.ToInt32(cbCountry.SelectedValue));
                MessageBox.Show("city was inserted successfully ... ");
                imp2.displayCities();
                acus2.displayCitiesCust();
                Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) { MessageBox.Show("حدث خطأ ما عند اضافة مدينة - الرجاء الاتصال بمدير النظام"); }
        }
    }
}
