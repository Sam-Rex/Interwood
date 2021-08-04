using System;
using System.Windows.Forms;

namespace EOM_stores.Ul.Categories
{
    public partial class aCat : Form
    {

        public void reDisplayCats()
        {
            _contr._cat catc = new _contr._cat();
            dgvEEWCat.DataSource = catc.displaySt_Categories();
            dgvEEStCat.DataSource = catc.displayWo_Categories();

            //dgvEEWCat.DataSource = catc.displayCat(1);
             dgvEEStCat.Columns[0].Visible = false;
             dgvEEWCat.Columns[0].Visible = false;
            //dgvEECat.Columns[5].Visible = false;
            //dgvEEStCat.Columns[6].Visible = false;
        }


        public void emptyFeild()
        {
            wCatName.Text = "";
            catWLongs.Text = "";
            catWWidth.Text = "";
            catWThickness.Text = "";
            catWDescription.Text = "";
            wVolum.Text = "";
            wPrice.Text = "";
            txtStCatName.Clear();
            stThickness.Clear();
            steelWeight.Clear();
            stLength.Clear();
            stdescription.Clear();
            stCPrice.Clear();

        }
        public aCat()
        {
            InitializeComponent();
            reDisplayCats();
            btnEdit.Enabled = false;
        }

        private void piExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        /*
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _contr._cat catc = new _contr._cat();
            if (catName.Text != ""||catLongs.Text != ""||catWidth.Text != ""||
                wVolum.Text != ""||catWPrice.Text != "")
            {
                
            catc.insertNewCat(catName.Text, Convert.ToInt32(catLongs.Text),
                Convert.ToInt32(catWidth.Text), Convert.ToDouble(catThickness.Text), cbQuality.Text, Convert.ToInt32(wVolum.Text),
                Convert.ToInt32(catWPrice.Text), catDescription.Text);
            MessageBox.Show("تم اضافة الصنف بنجاح");
            reDisplayCats();
            emptyFeild();
            }
            else
            {
                MessageBox.Show("رجاءً قم بملء الحقول الضرورية قبل عملية التعديل...");
                catName.Focus();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (catName.Text != "" || catLongs.Text != "" || catWidth.Text != "" ||
               wVolum.Text != "" || catWPrice.Text != "")
            {

                if (MessageBox.Show("هل تريد تعديل هذا الصنف ؟","تعديل صنف ", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                _contr._cat catc = new _contr._cat();
                catc.updateCat(Convert.ToInt32(dgvEEStCat.CurrentRow.Cells[0].Value.ToString()), catName.Text, Convert.ToInt32(catLongs.Text),
                   Convert.ToInt32(catWidth.Text), Convert.ToDouble(catThickness.Text),  Convert.ToDouble(wVolum.Text),
                   Convert.ToInt32(catWPrice.Text), catDescription.Text);
                MessageBox.Show("تمت عملية التعديل بنجاح ...");
                reDisplayCats();
                emptyFeild();
                    btnEdit.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show(" رجاءً قم بملء الحقول الضرورية...");
                catName.Focus();
            }
        }

        */

        private void btnNew_Click(object sender, EventArgs e)
        {
            emptyFeild();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAddStCat_Click(object sender, EventArgs e)
        {
            _contr._cat catc = new _contr._cat();
            if (txtStCatName.Text=="سيخ")
            {
                
                catc.insertNewCat(txtStCatName.Text, Convert.ToInt32(stLength.Text),Convert.ToInt32(0), Convert.ToDouble(stThickness.Text),Convert.ToDouble(0.00), 
                    Convert.ToInt32(steelWeight.Text),
                    Convert.ToDouble(stCPrice.Text),Convert.ToInt32(stCount.Text), stdescription.Text);
                MessageBox.Show("تم اضافة الصنف بنجاح");
                reDisplayCats();
                emptyFeild();
            } 
            else
            {
                
                catc.insertNewCat(txtStCatName.Text, Convert.ToDouble(stLength.Text), Convert.ToDouble(stThickness.Text), Convert.ToDouble(0.00), Convert.ToDouble(0.00),
                    Convert.ToInt32(steelWeight.Text),
                    Convert.ToDouble(stCPrice.Text), Convert.ToInt32(stCount.Text), stdescription.Text);
                MessageBox.Show("تم اضافة الصنف بنجاح");
            }
            
            reDisplayCats();
            emptyFeild();
        }

        private void btnAddWCat_Click(object sender, EventArgs e)
        {
            _contr._cat catc = new _contr._cat();
            if (wCatName.Text != "" || catWLongs.Text != "" || catWWidth.Text != "" ||
                wVolum.Text != "" || wPrice.Text != "")
            {

                try
                {
                    catc.insertNewCat(wCatName.Text, Convert.ToInt32(catWLongs.Text),
                        Convert.ToDouble(catWWidth.Text), Convert.ToDouble(catWThickness.Text), Convert.ToDouble(wVolum.Text), Convert.ToDouble(0.00),
                        Convert.ToInt32(wPrice.Text), Convert.ToInt32(wVolum.Text), catWDescription.Text);
                        MessageBox.Show("تم اضافة صنف خشبي  بنجاح");
                        reDisplayCats();
                        emptyFeild();
                }
                catch { MessageBox.Show("الرجاء التأكد من الخانات و المحاولة مرة أخرى !!", "خطأ إدخال", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                
            }
            else
            {
                MessageBox.Show("رجاءً قم بملء الحقول الضرورية قبل عملية اضافة بند خشبي ...");
                wCatName.Focus();
            }

        }

        private void dgvEEWCat_DoubleClick(object sender, EventArgs e)
        {
            
                wCatName.Text = dgvEEWCat.CurrentRow.Cells[1].Value.ToString();
                catWLongs.Text = dgvEEWCat.CurrentRow.Cells[2].Value.ToString();
                catWWidth.Text = dgvEEWCat.CurrentRow.Cells[3].Value.ToString();
                catWThickness.Text = dgvEEWCat.CurrentRow.Cells[4].Value.ToString();
                catWDescription.Text = dgvEEWCat.CurrentRow.Cells[9].Value.ToString();
                wVolum.Text = dgvEEWCat.CurrentRow.Cells[5].Value.ToString();
                wPrice.Text = dgvEEWCat.CurrentRow.Cells[7].Value.ToString();
                btnEdit.Enabled = true;
            
        }

        

        private void btnEditStCat_Click(object sender, EventArgs e)
        {
            if (txtStCatName.Text != "" || catWLongs.Text != "" || catWWidth.Text != "" ||
               wVolum.Text != "" || wPrice.Text != "")
            {

                if (MessageBox.Show("هل تريد تعديل هذا الصنف ؟", "تعديل صنف ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _contr._cat catc = new _contr._cat();
                    catc.updateCat(Convert.ToInt32(dgvEEStCat.CurrentRow.Cells[0].Value.ToString()), txtStCatName.Text, Convert.ToInt32(catWLongs.Text),
                       Convert.ToInt32(catWWidth.Text), Convert.ToDouble(catWThickness.Text),  Convert.ToDouble(wVolum.Text),
                       Convert.ToInt32(wPrice.Text), catWDescription.Text);
                    MessageBox.Show("تمت عملية التعديل بنجاح ...");
                    reDisplayCats();
                    emptyFeild();
                    btnEdit.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show(" رجاءً قم بملء خانة الاسم و الخانات الاضافية...");
                txtStCatName.Focus();
            }
        }

        private void dgvEEStCat_DoubleClick_1(object sender, EventArgs e)
        {
            if(dgvEEStCat.CurrentRow.Cells[1].Value.ToString()=="سيخ")
            {
                txtStCatName.Text = dgvEEStCat.CurrentRow.Cells[1].Value.ToString();
                stLength.Text = dgvEEStCat.CurrentRow.Cells[2].Value.ToString();
                stThickness.Text = dgvEEStCat.CurrentRow.Cells[4].Value.ToString();
                steelWeight.Text = dgvEEStCat.CurrentRow.Cells[6].Value.ToString();
                stCount.Text = dgvEEStCat.CurrentRow.Cells[5].Value.ToString();
                stCPrice.Text = dgvEEStCat.CurrentRow.Cells[7].Value.ToString();
                stdescription.Text = dgvEEStCat.CurrentRow.Cells[9].Value.ToString();
                btnEdit.Enabled = true;
            }
            else
            {
                txtStCatName.Text = dgvEEStCat.CurrentRow.Cells[1].Value.ToString();
                stLength.Text = dgvEEStCat.CurrentRow.Cells["البعد الرأسي"].Value.ToString();
                stThickness.Text = dgvEEStCat.CurrentRow.Cells["البعد الافقي"].Value.ToString();
                steelWeight.Text = dgvEEStCat.CurrentRow.Cells[6].Value.ToString();
                stCount.Text = dgvEEStCat.CurrentRow.Cells[5].Value.ToString();
                stCPrice.Text = dgvEEStCat.CurrentRow.Cells[7].Value.ToString();
                stdescription.Text = dgvEEStCat.CurrentRow.Cells[9].Value.ToString();
                btnEdit.Enabled = true;
            }
            
        }

        private void btndisMissStCat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف هذا الصنف ؟", "حذف صنف ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _contr._cat catc = new _contr._cat();
                catc.deleteCat(Convert.ToInt32(dgvEEStCat.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("تمت عملية الحذف بنجاح ...");
                reDisplayCats();
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف هذا الصنف ؟", "حذف صنف ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _contr._cat catc = new _contr._cat();
                catc.deleteCat(Convert.ToInt32(dgvEEWCat.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("تمت عملية الحذف بنجاح ...");
                reDisplayCats();
            }
        }

        private void btnPrepare_Click(object sender, EventArgs e)
        {
            emptyFeild();
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            emptyFeild();
        }
    }
}
