using System;
using System.Data;
using System.Windows.Forms;
using EOM_auth;
using EOM_stores;
namespace EOM_stores.Ul.Shared
{
    
    public partial class product : Form
    {

        _ctrlChannel _socket = new _ctrlChannel();
        _contr.products._prdc prdc = new _contr.products._prdc();
        Ul.Shared.eeProduct eep = new eeProduct();
        _contr.Shared.defineSection ds = new _contr.Shared.defineSection();

        //private static product nullableProductScreen;

        //static void homeScreen_Close(object sender, FormClosedEventArgs e)
        //{
        //    nullableProductScreen = null;
        //}

        //public static product decorateProduct
        //{
        //    get
        //    {
        //        if (nullableProductScreen == null)
        //        {
        //            nullableProductScreen = new product();
        //            nullableProductScreen.FormClosed += new FormClosedEventHandler(homeScreen_Close);
        //        }
        //        return nullableProductScreen;
        //    }


        //}

        public string formSection = "addProduct";
        public product()
        {
            InitializeComponent();
            DataTable ft = new DataTable();
            ft = _socket.getTargetId("@productId", "getProductId");
            int indexer = ft.Rows[0].Field<int>("Max(proId)");
            aPcode.Text ="PR "+(indexer + 1).ToString();

            cbCategory.DataSource = prdc.getCats("prd");
            cbCategory.DisplayMember = "catName";
            cbCategory.ValueMember = "catId";

            cbQuality.DataSource = prdc.getQul();
            cbQuality.DisplayMember = "qualityLabel";
            cbQuality.ValueMember = "idQuality";

        }

        private void piExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (formSection == "addProduct")
            {
                try
                {
                    prdc.insProduct(Convert.ToInt32(cbCategory.SelectedValue), Convert.ToInt32(prWoodPrice.Text), Convert.ToInt32(prQte.Text), Convert.ToDouble(prDiam.Text),
                        Convert.ToDouble(nuCuping.Text), Convert.ToInt32(prPrice.Text), Convert.ToInt32(cbQuality.SelectedValue), Convert.ToInt32(prInstall.Text), Convert.ToInt32(prPrepare.Text),
                        Convert.ToInt32(prTrenspo.Text), Convert.ToInt32(prSteels.Text), Convert.ToInt32(prRenting.Text));
                    MessageBox.Show("Product Inserted Susccessfully....");
                }
                catch (MySql.Data.MySqlClient.MySqlException ex) { MessageBox.Show("Error" + ex); }
            }
            else 
            {
                try
                {
                    prdc.updProduct(Convert.ToInt32(aPcode.Text), Convert.ToInt32(cbCategory.SelectedValue), Convert.ToInt32(prWoodPrice.Text), Convert.ToInt32(prQte.Text), Convert.ToDouble(prDiam.Text),
                    Convert.ToDouble(nuCuping.Text), Convert.ToInt32(prPrice.Text), Convert.ToInt32(cbQuality.SelectedValue), Convert.ToInt32(prInstall.Text), Convert.ToInt32(prPrepare.Text),
                    Convert.ToInt32(prTrenspo.Text), Convert.ToInt32(prSteels.Text), Convert.ToInt32(prRenting.Text));
                    ds.reDataPrd();
                    this.Close();
                    MessageBox.Show("Product updates Susccessfully....");
                }
                catch (MySql.Data.MySqlClient.MySqlException ex) { MessageBox.Show("Error" + ex); }
                
            }
        }
    }
        
}
