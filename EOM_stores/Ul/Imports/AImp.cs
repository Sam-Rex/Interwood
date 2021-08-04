using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EOM_stores.Ul.Imports
{
    public partial class AImp : Form
    {
        
        EOM_auth._ctrlChannel _socket = new EOM_auth._ctrlChannel();
        _contr.products._prdc prdc = new _contr.products._prdc();
        _contr.imports._imp imp = new _contr.imports._imp();
        _contr._custCtrl cutr = new _contr._custCtrl();
       

        private byte[] _impPicture, _IdPicture, _acPicture;

        private byte[] impPicture { get; set; }
        private byte[] IdPicture { get; set; }
        private byte[] acPicture { get; set; }

        private void pe ()
        {
            _impPicture = impPicture;
            _IdPicture = IdPicture;
            _acPicture = acPicture;
        }

        public void displayCities()
        {
            cbCity.DataSource = _socket.getCities();
            cbCity.DisplayMember = "cityName";
            cbCity.ValueMember = "cityId";
        }
        //public void displayPanel()
        //{
        //    Ul.customers.ACus adc = new customers.ACus();
        //    Panel pnl = new Panel();
        //    pnl = adc.paShared;
        //    adc.tCash.Width = 645;
        //    pnl.Location = new Point(3, 292);
        //    this.pImporterCon.Controls.Add(pnl);
        //    pnl.Visible = true;
        //}
        public AImp()
        {
            InitializeComponent();
            
            DataTable ft = new DataTable();
            ft = _socket.getTargetId("@importerId", "getImpId");
            int indexer = ft.Rows[0].Field<int>("Max(impId)");
            imCode.Text = ":    " + "IMP  " + (indexer + 1).ToString();
            

            IcpNatio.DataSource = _socket.getCountries();
            IcpNatio.DisplayMember = "conName";
            IcpNatio.ValueMember = "conId";

            displayCities();

            IcpCat.DataSource = prdc.getCats("imp");
            IcpCat.DisplayMember = "catName";
            IcpCat.ValueMember = "catId";

            cbIdType.DataSource = _socket.getId_type();
            cbIdType.DisplayMember = "type_lable";
            cbIdType.ValueMember = "typeCode";

           
        }


      

        private void iPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd2 = new OpenFileDialog();
            ofd2.Filter = "Importer Image | *.JPG; *.PNG;*.GIF;";
            if(ofd2.ShowDialog()==DialogResult.OK)
            {
                iPicture.Image = Image.FromFile(ofd2.FileName);
                iPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void piExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addCity_Click(object sender, EventArgs e)
        {
            adCity adci = new adCity();
            adci.Show();
            adci.Location = new Point(65, 432);
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            
                if (iPicture.Image == null)
                {

                     insertIdent();
                    _impPicture = new byte[0];

                    imp.insImporter("IMP", IFName.Text, IMName.Text, ILName.Text, IPhone.Text, impAddress.Text,
                        emailAddress.Text, imStatus.Text, _impPicture, Convert.ToInt32(cbCity.SelectedValue),
                        Convert.ToInt32(IcpNatio.SelectedValue), "n");
                    MessageBox.Show("تمت اضافة مورد بنجاح بدون صورة");
                }



                else if (iPicture.Image !=null)
                {

                    
                    insertIdent();
                    MemoryStream mStream = new MemoryStream();
                    iPicture.Image.Save(mStream, iPicture.Image.RawFormat);
                    _impPicture = mStream.ToArray();
                    imp.insImporter("IMP", IFName.Text, IMName.Text, ILName.Text, IPhone.Text, impAddress.Text,
                         emailAddress.Text, imStatus.Text, _impPicture, Convert.ToInt32(cbCity.SelectedValue),
                         Convert.ToInt32(IcpNatio.SelectedValue), "w");
                    MessageBox.Show("تمت اضافة مورد بنجاح مع وجود صورة");
                }
           
        }

       
        private void idPic_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "Identity Images | *.JPG;*.PNG;";
            if (opd.ShowDialog() == DialogResult.OK)
            {
                idPic.Image = Image.FromFile(opd.FileName);
                idPic.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

      

        public bool insertIdent()
        {
            try
            {
                _contr.identities._iden iden = new _contr.identities._iden();
                
                if (idPic.Image == null)
                {
                    _IdPicture = new byte[0];
                    iden.insertIdentity(idNombr.Text, "ID", Convert.ToInt32(cbIdType.SelectedValue), birthdate.Text,
                        idRelease.Text, idexpaier.Text, idIssuer.Text, idPlaceIssur.Text, _IdPicture, "n");
                    MessageBox.Show("تمت اضافة هوية بنجاح...");
                
                }

                else
                {
                    MemoryStream getIdPicture = new MemoryStream();
                    idPic.Image.Save(getIdPicture, idPic.Image.RawFormat);
                    _IdPicture = getIdPicture.ToArray();
                    iden.insertIdentity(idNombr.Text, "ID", Convert.ToInt32(cbIdType.SelectedValue), birthdate.Text,
                        idRelease.Text, idexpaier.Text, idIssuer.Text, idPlaceIssur.Text, _IdPicture, "w");

                    MessageBox.Show("تم اضافة هوية بنجاح...");
                }

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("error " + ex);
            }



            return true;
        }


        
    }
}
