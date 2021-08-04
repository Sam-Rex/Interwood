using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EOM_stores.Ul.Accounts
{
    public partial class inAccount : Form
    {

        string sec = "AddNew";
        private string _LetterId;
        private string _operation;
        private int _accountDirection=2;
        private byte[] _cheqePict;
        DataTable dt = new DataTable();

        public inAccount()
        {
            InitializeComponent();


            _contr._custCtrl cutr = new _contr._custCtrl();
            cbHow2Pay.DataSource = cutr.retAcotType();
            cbHow2Pay.DisplayMember = "Htype_lable";
            cbHow2Pay.ValueMember = "Hid_type";

            cbCustHow2Pay.DataSource = cutr.retAcotType();
            cbCustHow2Pay.DisplayMember = "Htype_lable";
            cbCustHow2Pay.ValueMember = "Hid_type";

            FromAcc.DataSource = cutr.getDefAco();
            FromAcc.DisplayMember = "aco_name";
            FromAcc.ValueMember = "nameId";

            ToAcc.DataSource = cutr.getDefAco();
            ToAcc.DisplayMember = "aco_name";
            ToAcc.ValueMember = "nameId";

            cbGetPayment.DataSource = cutr.getA_Customers();
            cbGetPayment.DisplayMember = "اسم العميل بالكامل";
            cbGetPayment.ValueMember = "عميل برقم";

        }

        private void piExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        private void impoAcc_CheckedChanged(object sender, EventArgs e)
        {
            _contr.imports.getImporters himp = new _contr.imports.getImporters();
            _contr.Shared._shared sha = new _contr.Shared._shared();
            cbPay2.DataSource = himp.getImp4edit();
            cbPay2.DisplayMember = "إسم المورد";
            cbPay2.ValueMember = "مورد رقم";
            dt.Clear();
            _LetterId = "IMP";
            try
            {
                _contr.accounts._getAccs gacc = new _contr.accounts._getAccs();
                dt = gacc.getTargetAcc(Convert.ToInt32(cbPay2.SelectedValue), _LetterId);
                textCurrentAcc.Text = dt.Rows[0].Field<double>("price").ToString();
                _operation = "outExistElement";
            }
            catch (IndexOutOfRangeException ioore) { textCurrentAcc.Text = "لا يوجد حساب"; }
            if (textCurrentAcc.Text == "لا يوجد حساب")
            {
                sec = "AddNew";
                _operation = "outNeweElement";
            }
            else
            {
                btnForward.BackgroundImage = Properties.Resources.Edit_refresh;
                sec = "AddExist";
            }

        }

        private void emAcc_CheckedChanged(object sender, EventArgs e)
        {
            _contr.employees.getEmployees gemp = new _contr.employees.getEmployees();
            
            
            cbPay2.DataSource = gemp.getA_employee();
            cbPay2.DisplayMember = "اسم الموظف";
            cbPay2.ValueMember = "موظف رقم";
            _LetterId = "EM";
            try
            {
                _contr.accounts._getAccs gacc = new _contr.accounts._getAccs();
                DataTable dt = new DataTable();
                dt = gacc.getTargetAcc(Convert.ToInt32(cbPay2.SelectedValue), _LetterId);
                textCurrentAcc.Text = dt.Rows[0].Field<double>("price").ToString();
                _operation = "outExistElement";
            }
            catch (IndexOutOfRangeException ioore) { textCurrentAcc.Text = "لا يوجد حساب"; }
            if (textCurrentAcc.Text == "لا يوجد حساب")
            {
                sec = "AddNew";
                _operation = "outNeweElement";
            }
            else
            {
                btnForward.BackgroundImage=Properties.Resources.Edit_refresh;
                sec = "AddExist";
                _operation = "outNeweElement";
            }

        }

        private void workAcc_CheckedChanged(object sender, EventArgs e)
        {
            _contr.workers.getWorkers gwo = new _contr.workers.getWorkers();
            _contr.Shared._shared sha = new _contr.Shared._shared();
            cbPay2.DataSource = gwo.getApcenWorkrs();
            cbPay2.DisplayMember = "اسم العامل";
            cbPay2.ValueMember = "معرف العامل";
            _LetterId = "WK";

            try
            {
                _contr.accounts._getAccs gacc = new _contr.accounts._getAccs();
                DataTable dt = new DataTable();
                dt = gacc.getTargetAcc(Convert.ToInt32(cbPay2.SelectedValue), _LetterId);
                textCurrentAcc.Text = dt.Rows[0].Field<double>("price").ToString();
                _operation = "outExistElement";
            }
            catch (IndexOutOfRangeException ioore) { textCurrentAcc.Text = "لا يوجد حساب"; }
            if (textCurrentAcc.Text == "لا يوجد حساب")
            {
                sec = "AddNew";
                _operation = "outNeweElement";
            }
            else
            {
                btnForward.BackgroundImage= Properties.Resources.Edit_refresh;
                sec = "AddExist";
            }
        }

        private void cheqePhoto_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "Cheque Image | *.JPG;*.PNG;";
            if (opd.ShowDialog() == DialogResult.OK)
            {
                cheqePhoto.Image = Image.FromFile(opd.FileName);
                cheqePhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (sec == "AddNew")
            {
                _contr.accounts._accCtrl accCtrl = new _contr.accounts._accCtrl();
                if(cheqePhoto.Image==null)
                {
                    _cheqePict = new byte[0];
                    accCtrl.insertNewAcot(Convert.ToInt32(cbHow2Pay.SelectedValue), _LetterId,Convert.ToInt32(cbPay2.SelectedValue),
                      _accountDirection,Convert.ToInt32(FromAcc.SelectedValue),cheqeSerial.Text,txtDetails.Text,Convert.ToDouble(txtAmount.Text),
                      txtIssuerPlace.Text, _cheqePict, _operation,"n");
                    MessageBox.Show("تم اضافة حساب جديد بنجاح ل " + cbPay2.SelectedText);
                    textCurrentAcc.Text = txtAmount.Text;
                }
                else
                {
                    MemoryStream getCheqePicture = new MemoryStream();
                    cheqePhoto.Image.Save(getCheqePicture, cheqePhoto.Image.RawFormat);
                    _cheqePict = getCheqePicture.ToArray();

                    accCtrl.insertNewAcot(Convert.ToInt32(cbHow2Pay.SelectedValue), _LetterId, Convert.ToInt32(cbPay2.SelectedValue),
                     _accountDirection, Convert.ToInt32(FromAcc.SelectedValue), cheqeSerial.Text, txtDetails.Text, Convert.ToDouble(txtAmount.Text),
                     txtIssuerPlace.Text, _cheqePict, _operation, "w");

                    MessageBox.Show("تم اضافة حساب بنجاح ل " + cbPay2.SelectedText);
                    textCurrentAcc.Text = txtAmount.Text;
                }
                
            }
            else if(sec == "AddExist")
            {
                _contr.accounts._accCtrl accCtrl = new _contr.accounts._accCtrl();
                if (cheqePhoto.Image == null)
                {
                    _cheqePict = new byte[0];
                    accCtrl.insertNewAcot(Convert.ToInt32(cbHow2Pay.SelectedValue), _LetterId, Convert.ToInt32(cbPay2.SelectedValue),
                      _accountDirection, Convert.ToInt32(FromAcc.SelectedValue), cheqeSerial.Text, txtDetails.Text, Convert.ToDouble(txtAmount.Text),
                      txtIssuerPlace.Text, _cheqePict, _operation, "n");
                    textCurrentAcc.Text = Convert.ToString(Convert.ToDouble(textCurrentAcc.Text) + Convert.ToDouble(txtAmount.Text));
                    MessageBox.Show("تم اضافة حركة مالية بنجاح " + cbPay2.SelectedText);
                    
                }
                else
                {
                    MemoryStream getCheqePicture = new MemoryStream();
                    cheqePhoto.Image.Save(getCheqePicture, cheqePhoto.Image.RawFormat);
                    _cheqePict = getCheqePicture.ToArray();

                    accCtrl.insertNewAcot(Convert.ToInt32(cbHow2Pay.SelectedValue), _LetterId, Convert.ToInt32(cbPay2.SelectedValue),
                     _accountDirection, Convert.ToInt32(FromAcc.SelectedValue), cheqeSerial.Text, txtDetails.Text, Convert.ToDouble(txtAmount.Text),
                     txtIssuerPlace.Text, _cheqePict, _operation, "w");
                    textCurrentAcc.Text = Convert.ToString(Convert.ToDouble(textCurrentAcc.Text) + Convert.ToDouble(txtAmount.Text));
                    MessageBox.Show("تم اضافة حركة مالية بنجاح " + cbPay2.SelectedText);
                }
            }
        }

        private void cbPay2_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void acoInPhotos_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "Cheque Image | *.JPG;*.PNG;";
            if (opd.ShowDialog() == DialogResult.OK)
            {
                acoInPhotos.Image = Image.FromFile(opd.FileName);
                acoInPhotos.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void custAddAcc_Click(object sender, EventArgs e)
        {
            _accountDirection = 1;
            _operation = "inE_Customer";
            _contr.accounts._accCtrl accCtrl = new _contr.accounts._accCtrl();
            if (acoInPhotos.Image == null)
            {
                _cheqePict = new byte[0];
                accCtrl.insertNewAcot(Convert.ToInt32(cbCustHow2Pay.SelectedValue), "CU", Convert.ToInt32(cbGetPayment.SelectedValue),
                  _accountDirection, Convert.ToInt32(ToAcc.SelectedValue), cheqeSeialNo.Text,txtDesc.Text, Convert.ToDouble(txtCost.Text),
                  issuerPlace.Text, _cheqePict, _operation, "n");
                
                MessageBox.Show("تم اضافة حركة مالية بنجاح " );

                this.Close();
            }
            else
            {
                MemoryStream getCheqePicture = new MemoryStream();
                acoInPhotos.Image.Save(getCheqePicture, cheqePhoto.Image.RawFormat);
                _cheqePict = getCheqePicture.ToArray();

                accCtrl.insertNewAcot(Convert.ToInt32(cbCustHow2Pay.SelectedValue), "CU", Convert.ToInt32(cbGetPayment.SelectedValue),
                 _accountDirection, Convert.ToInt32(ToAcc.SelectedValue), cheqeSeialNo.Text,txtDesc.Text, Convert.ToDouble(txtCost.Text),
                 issuerPlace.Text, _cheqePict, _operation, "w");

                MessageBox.Show("تم اضافة حركة مالية بنجاح " );

                this.Close();
            }
        }

        private void cbPay2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt.Clear();
            try
            {
                try { 
                _contr.accounts._getAccs gacc = new _contr.accounts._getAccs();
                DataTable dt = new DataTable();
                dt = gacc.getTargetAcc(Convert.ToInt32(cbPay2.SelectedValue), _LetterId);
                textCurrentAcc.Text = dt.Rows[0].Field<double>("price").ToString();
                _operation = "outExistElement";
                }catch(InvalidCastException icx) { }
            }
            catch (IndexOutOfRangeException ioore) { textCurrentAcc.Text = "لا يوجد حساب"; }
            if (textCurrentAcc.Text == "لا يوجد حساب")
            {
                sec = "AddNew";
                _operation = "outNeweElement";
            }
            else
            {
                btnForward.BackgroundImage = Properties.Resources.Edit_refresh;
                sec = "AddExist";
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            Manages.eeAccount eeacc = new Manages.eeAccount();
            eeacc.Show();
            this.Close();
        }
    }
}
