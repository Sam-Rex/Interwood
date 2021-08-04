using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace EOM_stores.Ul.Manages
{
    public partial class eeCustomers : Form
    {
        _contr.customers.getCust gcust;
        _contr.identities._getIdens giden;
        _contr.accounts._getAccs gacc;

        public int _identityNumber;
        public int identityNumber { get; set; }
        public eeCustomers()
        {
            InitializeComponent();
        }

        private void piExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void prep()
        {
            _identityNumber = identityNumber;
        }
        public void bringCust2Edit()
        {
            Ul.customers.ACus acus = new customers.ACus();
            gcust = new _contr.customers.getCust();
            gacc = new _contr.accounts._getAccs();
            giden = new _contr.identities._getIdens();
            DataTable dt, at, it = new DataTable();
            dt = gcust.getCust4Edit(Convert.ToInt32(this.dgvEECustomer.CurrentRow.Cells[0].Value.ToString()));
            acus.aCcode.Text = Convert.ToString(dt.Rows[0].Field<int>("custId"));
            acus.cFName.Text = dt.Rows[0].Field<string>("fName");
            acus.cMName.Text = dt.Rows[0].Field<string>("midNName");
            acus.cLName.Text = dt.Rows[0].Field<string>("lName");
            acus.cPhone.Text = dt.Rows[0].Field<string>("phoneNo");
            acus.cEmail.Text = dt.Rows[0].Field<string>("eMail");
            acus.cAddress.Text = dt.Rows[0].Field<string>("address");
            acus.cPhone.Text = dt.Rows[0].Field<string>("phoneNo");
            acus.cStatus.Text = dgvEECustomer.CurrentRow.Cells[5].Value.ToString();
            acus.icpCountry.Text = dt.Rows[0].Field<string>("conName");
            acus.cbCity.Text = dt.Rows[0].Field<string>("cityName");
            try
            {
                byte[] cImage = (byte[])dt.Rows[0].Field<byte[]>("custPict");
                if (cImage != null)
                {
                    MemoryStream mstr = new MemoryStream(cImage);
                    acus.cPicture.Image = Image.FromStream(mstr);
                }
                else
                {
                    acus.cPicture.Image = null;
                }
            }
            catch (System.ArgumentException rx) { MessageBox.Show("حدث خطأ اثناء تحميل صورة العميل | يرجى المحاولة لاحقاً  "); }
            at = gacc.accs4Edit(Convert.ToInt32(this.dgvEECustomer.CurrentRow.Cells[6].Value.ToString()));
            acus.tAccount.Text = at.Rows[0].Field<string>("direction");
            acus.cbHo2Pay.Text = at.Rows[0].Field<string>("Htype_lable");
            acus.chequeSerial.Text = at.Rows[0].Field<string>("cheqeSerialNo");
            acus.txtIssuer.Text = at.Rows[0].Field<string>("issuer");
            try
            {
                byte[] accImage = (byte[])at.Rows[0].Field<byte[]>("accRefarePhoto");
                if (accImage != null)
                {
                    MemoryStream mstr2 = new MemoryStream(accImage);
                    acus.acoPhotos.Image = Image.FromStream(mstr2);
                }
                else
                {
                    acus.acoPhotos.Image = null;
                }
            }
            catch (System.ArgumentException rx) { MessageBox.Show("حدث خطأ اثناء تحميل صورة الشيك | يرجى المحاولة لاحقاً "); }
            acus.txtStatements.Text = at.Rows[0].Field<string>("statements");
            acus.acoPrice.Text = Convert.ToString(at.Rows[0].Field<double>("price"));

            it = giden.getId4Edit(this.dgvEECustomer.CurrentRow.Cells[10].Value.ToString());
            acus.idNombr.Text = dgvEECustomer.CurrentRow.Cells[10].Value.ToString();
            acus.cbIdType.Text = it.Rows[0].Field<string>("type_lable");
            acus.idIssuer.Text = it.Rows[0].Field<string>("Issuer");
            acus.idPlaceIssur.Text = it.Rows[0].Field<string>("issuingPlace");
            acus.birthdate.Text = it.Rows[0].Field<string>("birthDate");
            acus.idRelease.Text = it.Rows[0].Field<string>("releaseDate");
            acus.idexpaier.Text = it.Rows[0].Field<string>("expiryDate");
            _identityNumber = it.Rows[0].Field<int>("identify");
            try
            {

                byte[] idImage = (byte[])it.Rows[0].Field<byte[]>("scanIdentityImage");
                if (idImage != null)
                {
                    MemoryStream mstr3 = new MemoryStream(idImage);
                    acus.idPic.Image = Image.FromStream(mstr3);
                }
                else
                {
                    acus.idPic.Image = null;
                }
            }
            catch (System.ArgumentException rx) { MessageBox.Show("حدث خطأ اثناء تحميل صورة الشيك | يرجى المحاولة لاحقاً "); }
            

            acus.TopMost = true;
            acus.Location = new Point(20, 50);
            acus.Show();
        }

        private void dgvEECustomer_DoubleClick(object sender, EventArgs e)
        {
            bringCust2Edit();
        }

        private void btnEditRecord_Click(object sender, EventArgs e)
        {
            bringCust2Edit();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

        }
    }
}
