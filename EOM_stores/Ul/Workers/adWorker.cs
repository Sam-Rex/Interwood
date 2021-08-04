using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using EOM_stores._contr.Shared;
using EOM_auth;

namespace EOM_stores.Ul.Worksh
{
    public partial class adWorker : Form
    {
        
        _ctrlChannel _socket ;
        public string FormSection = "AddNewWorker";
        private byte[] _IdPicture;
        private byte[] IdPicture { get; set; }

        private byte[] _worPicture;
        private byte[] worPicture { get; set; }

        void pre()
        {
            _IdPicture = IdPicture;
            _worPicture = worPicture;
        }
        public adWorker()
        {
            InitializeComponent();


            try
            {
                _socket = new _ctrlChannel();

                DataTable ft = new DataTable();
                ft = _socket.getTargetId("@workerId", "getWorkerId");
                int indexer = ft.Rows[0].Field<int>("Max(worId)");
                aCcode.Text = "WK" + ":    " + (indexer + 1).ToString();

                ccpNation.DataSource = _socket.getCountries();
                ccpNation.DisplayMember = "conName";
                ccpNation.ValueMember = "conId";

                ccpCity.DataSource = _socket.getCities();
                ccpCity.DisplayMember = "cityName";
                ccpCity.ValueMember = "cityId";

                cbHostels.DataSource = _socket.getHostels();
                cbHostels.DisplayMember = "hostName";
                cbHostels.ValueMember = "hostId";

                cStatus.DataSource = _socket.getStatus();
                cStatus.DisplayMember = "ststus_lable";
                cStatus.ValueMember = "statusId";

            }
            catch { }


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


        private void cPicture_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "Workers Image | *.JPG;*.PNG;";
            if (opd.ShowDialog() == DialogResult.OK)
            {
                woPicture.Image = Image.FromFile(opd.FileName);
                woPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void addCity_Click(object sender, EventArgs e)
        {
            Ul.adCity adc = new adCity();
            adc.Show();
        }

        private void piExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            _contr.workers._ctrlWorkers works = new _contr.workers._ctrlWorkers();

            if(wFName.Text != string.Empty && wSalary.Text != string.Empty)
            {
                if(woPicture.Image == null)
                {
                    insertIdent();
                    _worPicture = new byte[0];
                    works.insertWorker(wFName.Text,wLName.Text,cPhone.Text,wAddress.Text,wEmail.Text,dpHiredate.Text,
                        Convert.ToDouble(wSalary.Text),Convert.ToInt32(ccpCity.SelectedValue), Convert.ToInt32(ccpNation.SelectedValue),
                        Convert.ToInt32(cStatus.SelectedValue), Convert.ToInt32(cbHostels.SelectedValue),_worPicture);
                    MessageBox.Show("تم اضافة عامل بنجاح");
                }

                else
                {
                    insertIdent();
                    MemoryStream mst = new MemoryStream();
                    woPicture.Image.Save(mst, woPicture.Image.RawFormat);
                    _worPicture = mst.ToArray();
                    works.insertWorker(wFName.Text, wLName.Text, cPhone.Text, wAddress.Text, wEmail.Text, dpHiredate.Text,
                        Convert.ToDouble(wSalary.Text), Convert.ToInt32(ccpCity.SelectedValue), Convert.ToInt32(ccpNation.SelectedValue),
                        Convert.ToInt32(cStatus.SelectedValue), Convert.ToInt32(cbHostels.SelectedValue), _worPicture);
                    MessageBox.Show("تم اضافة عامل بنجاح");
                }
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
