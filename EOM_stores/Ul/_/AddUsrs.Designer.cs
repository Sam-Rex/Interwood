namespace EOM_stores.Ul.__
{
    partial class AddUsrs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.piExit = new System.Windows.Forms.PictureBox();
            this.eEpNav = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.usrType = new System.Windows.Forms.ComboBox();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.confirmPasswd = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.passwd = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.usrName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.piExit)).BeginInit();
            this.eEpNav.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // piExit
            // 
            this.piExit.BackColor = System.Drawing.Color.Transparent;
            this.piExit.BackgroundImage = global::EOM_stores.Properties.Resources.controlTools;
            this.piExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.piExit.Location = new System.Drawing.Point(12, 2);
            this.piExit.Name = "piExit";
            this.piExit.Size = new System.Drawing.Size(20, 20);
            this.piExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piExit.TabIndex = 3;
            this.piExit.TabStop = false;
            this.piExit.Click += new System.EventHandler(this.piExit_Click);
            // 
            // eEpNav
            // 
            this.eEpNav.BackgroundImage = global::EOM_stores.Properties.Resources.navigatiopn21;
            this.eEpNav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eEpNav.Controls.Add(this.piExit);
            this.eEpNav.Controls.Add(this.panel2);
            this.eEpNav.Controls.Add(this.panel1);
            this.eEpNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.eEpNav.Location = new System.Drawing.Point(0, 0);
            this.eEpNav.Name = "eEpNav";
            this.eEpNav.Size = new System.Drawing.Size(473, 29);
            this.eEpNav.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(3, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(3, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(1, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(471, 406);
            this.panel3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "ترقية مستخدم";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.usrType);
            this.groupBox1.Controls.Add(this.cbEmployee);
            this.groupBox1.Controls.Add(this.confirmPasswd);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.passwd);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.usrName);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(17, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 275);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات المستخدم";
            // 
            // usrType
            // 
            this.usrType.BackColor = System.Drawing.SystemColors.HighlightText;
            this.usrType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usrType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.usrType.FormattingEnabled = true;
            this.usrType.Location = new System.Drawing.Point(43, 66);
            this.usrType.Margin = new System.Windows.Forms.Padding(7);
            this.usrType.Name = "usrType";
            this.usrType.Size = new System.Drawing.Size(234, 28);
            this.usrType.TabIndex = 6;
            // 
            // cbEmployee
            // 
            this.cbEmployee.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmployee.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(43, 30);
            this.cbEmployee.Margin = new System.Windows.Forms.Padding(7);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(234, 28);
            this.cbEmployee.TabIndex = 6;
            // 
            // confirmPasswd
            // 
            // 
            // 
            // 
            this.confirmPasswd.CustomButton.Image = null;
            this.confirmPasswd.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.confirmPasswd.CustomButton.Name = "";
            this.confirmPasswd.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.confirmPasswd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.confirmPasswd.CustomButton.TabIndex = 1;
            this.confirmPasswd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.confirmPasswd.CustomButton.UseSelectable = true;
            this.confirmPasswd.CustomButton.Visible = false;
            this.confirmPasswd.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.confirmPasswd.Lines = new string[0];
            this.confirmPasswd.Location = new System.Drawing.Point(43, 168);
            this.confirmPasswd.MaxLength = 32767;
            this.confirmPasswd.Name = "confirmPasswd";
            this.confirmPasswd.PasswordChar = '*';
            this.confirmPasswd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.confirmPasswd.SelectedText = "";
            this.confirmPasswd.SelectionLength = 0;
            this.confirmPasswd.SelectionStart = 0;
            this.confirmPasswd.ShortcutsEnabled = true;
            this.confirmPasswd.Size = new System.Drawing.Size(234, 25);
            this.confirmPasswd.Style = MetroFramework.MetroColorStyle.Silver;
            this.confirmPasswd.TabIndex = 4;
            this.confirmPasswd.UseSelectable = true;
            this.confirmPasswd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.confirmPasswd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.confirmPasswd.Validating += new System.ComponentModel.CancelEventHandler(this.confirmPasswd_Validating);
            this.confirmPasswd.Validated += new System.EventHandler(this.confirmPasswd_Validated);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(287, 167);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(137, 25);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "تأكيد كلمة المرور";
            // 
            // passwd
            // 
            // 
            // 
            // 
            this.passwd.CustomButton.Image = null;
            this.passwd.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.passwd.CustomButton.Name = "";
            this.passwd.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.passwd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwd.CustomButton.TabIndex = 1;
            this.passwd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwd.CustomButton.UseSelectable = true;
            this.passwd.CustomButton.Visible = false;
            this.passwd.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.passwd.Lines = new string[0];
            this.passwd.Location = new System.Drawing.Point(43, 135);
            this.passwd.MaxLength = 32767;
            this.passwd.Name = "passwd";
            this.passwd.PasswordChar = '*';
            this.passwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwd.SelectedText = "";
            this.passwd.SelectionLength = 0;
            this.passwd.SelectionStart = 0;
            this.passwd.ShortcutsEnabled = true;
            this.passwd.Size = new System.Drawing.Size(234, 25);
            this.passwd.Style = MetroFramework.MetroColorStyle.Silver;
            this.passwd.TabIndex = 4;
            this.passwd.UseSelectable = true;
            this.passwd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(287, 134);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(97, 25);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "كلمة المرور";
            // 
            // usrName
            // 
            // 
            // 
            // 
            this.usrName.CustomButton.Image = null;
            this.usrName.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.usrName.CustomButton.Name = "";
            this.usrName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.usrName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.usrName.CustomButton.TabIndex = 1;
            this.usrName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.usrName.CustomButton.UseSelectable = true;
            this.usrName.CustomButton.Visible = false;
            this.usrName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.usrName.Lines = new string[0];
            this.usrName.Location = new System.Drawing.Point(43, 103);
            this.usrName.MaxLength = 45;
            this.usrName.Name = "usrName";
            this.usrName.PasswordChar = '\0';
            this.usrName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usrName.SelectedText = "";
            this.usrName.SelectionLength = 0;
            this.usrName.SelectionStart = 0;
            this.usrName.ShortcutsEnabled = true;
            this.usrName.Size = new System.Drawing.Size(234, 25);
            this.usrName.Style = MetroFramework.MetroColorStyle.Silver;
            this.usrName.TabIndex = 3;
            this.usrName.UseSelectable = true;
            this.usrName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.usrName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(287, 66);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(117, 25);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "نوع المستخدم";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(287, 101);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(122, 25);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "اسم المستخدم";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(287, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(112, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "اسم الموظف";
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.Transparent;
            this.btnReject.BackgroundImage = global::EOM_stores.Properties.Resources.cancel;
            this.btnReject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReject.FlatAppearance.BorderSize = 0;
            this.btnReject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Location = new System.Drawing.Point(247, 439);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(32, 30);
            this.btnReject.TabIndex = 9;
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.Transparent;
            this.btnAccept.BackgroundImage = global::EOM_stores.Properties.Resources.accept;
            this.btnAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Location = new System.Drawing.Point(208, 439);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(33, 30);
            this.btnAccept.TabIndex = 8;
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // AddUsrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 480);
            this.ControlBox = false;
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.eEpNav);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUsrs";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "إضافة مستخدم جديد";
            ((System.ComponentModel.ISupportInitialize)(this.piExit)).EndInit();
            this.eEpNav.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox piExit;
        private System.Windows.Forms.Panel eEpNav;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox usrType;
        public System.Windows.Forms.ComboBox cbEmployee;
        public MetroFramework.Controls.MetroTextBox confirmPasswd;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        public MetroFramework.Controls.MetroTextBox passwd;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroTextBox usrName;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnAccept;
    }
}