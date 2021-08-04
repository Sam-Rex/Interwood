using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using EOM_auth;
using System.Windows.Forms;

namespace EOM_stores.Ul.Employees
{
    public partial class AdEmployee : Form
    {
        _contr.employees.empCtrl emps;
        _ctrlChannel _socket;
        private byte[] _empPicture, _IdPicture;

        private byte[] empPicture { get; set; }
        private byte[] IdPicture { get; set; }
        public AdEmployee()
        {
            InitializeComponent();

            _socket = new _ctrlChannel();

            DataTable ft = new DataTable();
            ft = _socket.getTargetId("@customerId", "getCustomerId");

            int indexer = ft.Rows[0].Field<int>("Max(custId)");
            string letterId = ft.Rows[0].Field<string>("custLetterId");
            aCcode.Text = ":    " + "EM" + (indexer + 1).ToString();


            try
            {
                cbCity.DataSource = _socket.getCities();
                cbCity.DisplayMember = "cityName";
                cbCity.ValueMember = "cityId";

                ccpNatio.DataSource = _socket.getCountries();
                ccpNatio.DisplayMember = "conName";
                ccpNatio.ValueMember = "conId";
                
                cbIdType.DataSource = _socket.getId_type();
                cbIdType.DisplayMember = "type_lable";
                cbIdType.ValueMember = "typeCode";

                cbJob.DataSource = _socket.getJobs();
                cbJob.DisplayMember = "jobTitle";
                cbJob.ValueMember = "jobId"; 

            }
            catch (NullReferenceException nre) { nre.ToString(); }

        }

        private void piExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmpPicture_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "Employees Image | *.JPG;*.PNG;";
            if (opd.ShowDialog() == DialogResult.OK)
            {
                EmpPicture.Image = Image.FromFile(opd.FileName);
                EmpPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {


            emps = new _contr.employees.empCtrl();
            
            if(EmpPicture.Image == null)
            {
                _empPicture = new byte[0];
                insertIdent();

                emps.insertNewEmpl(eFName.Text, eMName.Text, eLName.Text, ePhone.Text, address.Text, email.Text, Convert.ToDouble(eSalary.Text),
                dpHireDate.Text, Convert.ToInt32(cbJob.SelectedValue), Convert.ToInt32(cbCity.SelectedValue), Convert.ToInt32(ccpNatio.SelectedValue), _empPicture);
                MessageBox.Show("تمت الاضافة بنجاح");
            }

            else
            {


                insertIdent();
                MemoryStream ms = new MemoryStream();
                EmpPicture.Image.Save(ms, EmpPicture.Image.RawFormat);
                _empPicture = ms.ToArray();
                emps.insertNewEmpl(eFName.Text, eMName.Text, eLName.Text, ePhone.Text, address.Text, email.Text,
                    Convert.ToDouble(eSalary.Text),dpHireDate.Text, Convert.ToInt32(cbJob.SelectedValue), Convert.ToInt32(cbCity.SelectedValue),
                    Convert.ToInt32(ccpNatio.SelectedValue), _empPicture);
                MessageBox.Show("تمت الاضافة بنجاح");
            }

            

        }

        private void idPic_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "Identities Image | *.JPG;*.PNG;";
            if (opd.ShowDialog() == DialogResult.OK)
            {
                idPic.Image = Image.FromFile(opd.FileName);
                idPic.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void addCity_Click(object sender, EventArgs e)
        {
            Ul.adCity adc = new adCity();
            adc.Show();
        }


        /// <summary>
        /// this method return value if the identity was inserted successfully or not 
        /// </summary>
        /// <returns></returns>
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
