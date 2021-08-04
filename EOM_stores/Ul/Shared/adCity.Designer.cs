namespace EOM_stores.Ul
{
    partial class adCity
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
            this.pacNavigiation = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panMainAdC = new System.Windows.Forms.Panel();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGovernate = new System.Windows.Forms.TextBox();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.pacNavigiation.SuspendLayout();
            this.panMainAdC.SuspendLayout();
            this.SuspendLayout();
            // 
            // pacNavigiation
            // 
            this.pacNavigiation.BackColor = System.Drawing.Color.Transparent;
            this.pacNavigiation.BackgroundImage = global::EOM_stores.Properties.Resources.navigatiopn21;
            this.pacNavigiation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pacNavigiation.Controls.Add(this.label4);
            this.pacNavigiation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pacNavigiation.Location = new System.Drawing.Point(0, 0);
            this.pacNavigiation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pacNavigiation.Name = "pacNavigiation";
            this.pacNavigiation.Size = new System.Drawing.Size(539, 28);
            this.pacNavigiation.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(407, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "إضافة مدينة جديدة";
            // 
            // panMainAdC
            // 
            this.panMainAdC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panMainAdC.Controls.Add(this.cbCountry);
            this.panMainAdC.Controls.Add(this.label3);
            this.panMainAdC.Controls.Add(this.label2);
            this.panMainAdC.Controls.Add(this.label1);
            this.panMainAdC.Controls.Add(this.txtGovernate);
            this.panMainAdC.Controls.Add(this.txtCityName);
            this.panMainAdC.Location = new System.Drawing.Point(0, 31);
            this.panMainAdC.Name = "panMainAdC";
            this.panMainAdC.Size = new System.Drawing.Size(539, 100);
            this.panMainAdC.TabIndex = 1;
            // 
            // cbCountry
            // 
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(23, 37);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(96, 28);
            this.cbCountry.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "المحافظة ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(459, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = " المدينة";
            // 
            // txtGovernate
            // 
            this.txtGovernate.Location = new System.Drawing.Point(143, 38);
            this.txtGovernate.Name = "txtGovernate";
            this.txtGovernate.Size = new System.Drawing.Size(118, 27);
            this.txtGovernate.TabIndex = 1;
            this.txtGovernate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(340, 36);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(114, 27);
            this.txtCityName.TabIndex = 0;
            this.txtCityName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.btnReject.Location = new System.Drawing.Point(283, 137);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(31, 29);
            this.btnReject.TabIndex = 4;
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
            this.btnAccept.Location = new System.Drawing.Point(229, 137);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(30, 28);
            this.btnAccept.TabIndex = 3;
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // adCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 171);
            this.ControlBox = false;
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.panMainAdC);
            this.Controls.Add(this.pacNavigiation);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "adCity";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة مدينة جديدة";
            this.pacNavigiation.ResumeLayout(false);
            this.pacNavigiation.PerformLayout();
            this.panMainAdC.ResumeLayout(false);
            this.panMainAdC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pacNavigiation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panMainAdC;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGovernate;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnAccept;
    }
}