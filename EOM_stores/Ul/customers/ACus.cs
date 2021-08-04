using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using EOM_stores._contr;
using EOM_auth;

namespace EOM_stores.Ul.customers
{
    
    public partial class ACus : Form
    {
        
        public string FormSection = "AddNewCustomer";
       
        _custCtrl cutr = new _custCtrl();
        _ctrlChannel _socket = new _ctrlChannel();
        Imports.AImp imp3 = new Imports.AImp();

        int indexer;



        public void displayCitiesCust()
        {
            cbCity.DataSource = _socket.getCities();
            cbCity.DisplayMember = "cityName";
            cbCity.ValueMember = "cityId";
        }
        public ACus()
        {

            InitializeComponent();
            
            if (FormSection == "AddNewCustomer")
            {
                try
                {
                 
                DataTable ft = new DataTable();
                ft = _socket.getTargetId("@customerId", "getCustomerId");
                  
                 indexer = ft.Rows[0].Field<int>("Max(custId)");
                //string letterId = ft.Rows[0].Field<string>("custLetterId");
                aCcode.Text = ":    "+"CU" +(indexer+1).ToString();
                 

                icpCountry.DataSource = _socket.getCountries();
                icpCountry.DisplayMember = "conName";
                icpCountry.ValueMember = "conId";

                displayCitiesCust();

                cbIdType.DataSource = _socket.getId_type();
                cbIdType.DisplayMember = "type_lable";
                cbIdType.ValueMember = "typeCode";

                toAccount.DataSource = cutr.getDefAco();
                toAccount.DisplayMember = "aco_name"; 
                toAccount.ValueMember = "nameId";

                cbHo2Pay.DataSource = cutr.retAcotType();
                cbHo2Pay.DisplayMember = "Htype_lable";
                cbHo2Pay.ValueMember = "Hid_type";

              
                }
                catch(NullReferenceException re) { MessageBox.Show(Convert.ToString(re)); }
            }

        }

        private void piExit_MouseHover(object sender, EventArgs e)
        {
          

        }

        private void piExit_MouseLeaver(object sender, EventArgs e)
        {
          
          
        }

        private void cPicture_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "Customer Image | *.JPG;*.PNG;";
            if(opd.ShowDialog()==DialogResult.OK)
            {
                cPicture.Image =Image.FromFile(opd.FileName);
                cPicture.SizeMode =PictureBoxSizeMode.StretchImage;
            }
        }

        private void piExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void cPicture_MouseHover(object sender, EventArgs e)
        {
            //this part has some logical erors i dont know what it's but i will see it latter because it does not work...
            if(cPicture.BackgroundImage!= null)
            { 
            Image rt = BackgroundImage;
            //pr.setViews(Width, Height, rt);
            //pr._prIContainer.Visible = true;
            }
        }

 
        private void btnReject_MouseHover(object sender, EventArgs e)
        {
            btnReject.Size = new Size(35, 32);
        }

        private void btnReject_MouseLeave(object sender, EventArgs e)
        {
            btnReject.Size = new Size(33, 30);
        }

        private void btnAccept_MouseHover(object sender, EventArgs e)
        {
            btnAccept.Size = new Size(35, 32);
        }

        private void btnAccept_MouseLeave(object sender, EventArgs e)
        {
            btnAccept.Size = new Size(33, 30);
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            Close();
        }

        private byte[] _IdPicture, _acPicture,_custPicture;
        private byte[] IdPicture { get; set; }

        private byte[] custPicture { get; set; }
        private byte[] acPicture { get; set; }

        private int _ident,_accoun;
        private int ident { get; set; }
        private int accoun { get; set; }
        private void redo()
        {
            _IdPicture = IdPicture;
            _acPicture = acPicture;
            _custPicture = custPicture;
            _ident = ident;
            _accoun = accoun;
        }

        public bool insertIdent()
        {
            try
            {
                _contr.identities._iden iden = new _contr.identities._iden();
                
                //cutr.insertNewCust(Convert.ToInt16(aCcode.Text),cFName.Text,cMName.Text,cAddress.Text,cEmail.Text,Convert.ToInt16(ccpCity.SelectedValue), Convert.ToInt16(ccpCountry.SelectedValue),);
                if (idPic.Image ==Properties.Resources.idenPicture)
                {
                    _IdPicture = new byte[0];
                    iden.insertIdentity(idNombr.Text, "ID", Convert.ToInt32(cbIdType.SelectedValue), birthdate.Text,
                        idRelease.Text, idexpaier.Text, idIssuer.Text, idPlaceIssur.Text, _IdPicture, "n");
                    DataTable at = new DataTable();
                    at = _socket.getTargetId("@identityId", "getIdenId");
                    _ident = at.Rows[0].Field<int>("Max(identify)");
                    MessageBox.Show("Identity Inserted Successfully with-out a picture...");
                    //they are other way to view messages will update latter in final tuochs .
                }

                else
                {
                    MemoryStream getIdPicture = new MemoryStream();
                    idPic.Image.Save(getIdPicture, idPic.Image.RawFormat);
                    _IdPicture = getIdPicture.ToArray();
                    iden.insertIdentity(idNombr.Text, "ID", Convert.ToInt32(cbIdType.SelectedValue), birthdate.Text,
                        idRelease.Text, idexpaier.Text, idIssuer.Text, idPlaceIssur.Text, _IdPicture, "w");
                   
                    MessageBox.Show("Identity Inserted Successfully with a picture...");
                }

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("error " + ex);
            }



            return true;
        }


        public bool insAccount() 
        {
            try
            {
                _contr.accounts._accCtrl acc = new _contr.accounts._accCtrl();

                //cutr.insertNewCust(Convert.ToInt16(aCcode.Text),cFName.Text,cMName.Text,cAddress.Text,cEmail.Text,Convert.ToInt16(ccpCity.SelectedValue), Convert.ToInt16(ccpCountry.SelectedValue),);
                if (acoPhotos.Image == null)
                {
                    
                    _acPicture = new byte[0];
                    acc.insertNewAcot(Convert.ToInt32(cbHo2Pay.SelectedValue),"CU", indexer+1,1,
                        Convert.ToInt32(toAccount.SelectedValue),chequeSerial.Text,txtStatements.Text,Convert.ToDouble(acoPrice.Text),
                        txtIssuer.Text, _acPicture,"inN_Customer","n");
                    
                }

                else if(acoPhotos.Image != null)
                {
                    MemoryStream getAccPicture = new MemoryStream();
                    acoPhotos.Image.Save(getAccPicture, acoPhotos.Image.RawFormat);
                    _acPicture = getAccPicture.ToArray();
                    acc.insertNewAcot(Convert.ToInt32(cbHo2Pay.SelectedValue),"CU", indexer + 1, 1,
                         Convert.ToInt32(toAccount.SelectedValue), chequeSerial.Text, txtStatements.Text, Convert.ToDouble(acoPrice.Text),
                         txtIssuer.Text, _acPicture, "inN_Customer", "w");
                    MessageBox.Show("Account Inserted Successfully with a picture...");
                }

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("error " + ex);
            }



            return true;
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            // insert new customer statement 
            if (FormSection == "AddNewCustomer")
            {

                if (cPicture.Image == null)
                {

                    
                    insertIdent();
                    _custPicture = new byte[0];
                    cutr.insertNewCust("CU", cFName.Text, cMName.Text, cLName.Text, cPhone.Text, cAddress.Text, cEmail.Text, cStatus.Text,
                        _custPicture, Convert.ToInt32(cbCity.SelectedValue), Convert.ToInt32(icpCountry.SelectedValue), "n");
                    insAccount();
                    MessageBox.Show("تمت اضافة العميل بنجاح");
                }

                else
                {

                    
                    insertIdent();
                    MemoryStream mStream = new MemoryStream();
                    cPicture.Image.Save(mStream, cPicture.Image.RawFormat);
                    _custPicture = mStream.ToArray();
                    cutr.insertNewCust("CU", cFName.Text, cMName.Text, cLName.Text, cPhone.Text, cAddress.Text, cEmail.Text, cStatus.Text,
                        _custPicture, Convert.ToInt32(cbCity.SelectedValue), Convert.ToInt32(icpCountry.SelectedValue), "w");
                    insAccount();
                    MessageBox.Show("تمت اضافة العميل بنجاح");

                }
            }     

        }

           

    


        private void addCity_Click(object sender, EventArgs e)
        {
            adCity adci = new adCity();
            adci.Show();
            adci.Location = new Point(65, 432);
        }

        private void idPic_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "Identity Images | *.JPG;*.PNG;";
            if (opd.ShowDialog() == DialogResult.OK)
            {
                idPic.Image = Image.FromFile(opd.FileName);
                //idPic.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void acoPhotos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "Customer Image | *.JPG;*.PNG;";
            if (opd.ShowDialog() == DialogResult.OK)
            {
                acoPhotos.Image = Image.FromFile(opd.FileName);
                acoPhotos.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
