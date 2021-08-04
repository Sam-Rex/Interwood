namespace EOM_stores.Ul.Manages
{
    partial class workerCheck
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.piExit = new System.Windows.Forms.PictureBox();
            this.eEpNav = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEEWorkers = new System.Windows.Forms.DataGridView();
            this.comming = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.piExit)).BeginInit();
            this.eEpNav.SuspendLayout();
            this.pnContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEEWorkers)).BeginInit();
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
            this.eEpNav.Size = new System.Drawing.Size(1050, 29);
            this.eEpNav.TabIndex = 5;
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
            // pnContainer
            // 
            this.pnContainer.BackColor = System.Drawing.Color.White;
            this.pnContainer.Controls.Add(this.label1);
            this.pnContainer.Controls.Add(this.dgvEEWorkers);
            this.pnContainer.Location = new System.Drawing.Point(1, 30);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(1049, 565);
            this.pnContainer.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "نظام الحضــــــــــــــور / الغيـــــــاب";
            // 
            // dgvEEWorkers
            // 
            this.dgvEEWorkers.AllowUserToAddRows = false;
            this.dgvEEWorkers.AllowUserToDeleteRows = false;
            this.dgvEEWorkers.AllowUserToResizeColumns = false;
            this.dgvEEWorkers.AllowUserToResizeRows = false;
            this.dgvEEWorkers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEEWorkers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvEEWorkers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEEWorkers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEEWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEEWorkers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comming});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEEWorkers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEEWorkers.Location = new System.Drawing.Point(8, 45);
            this.dgvEEWorkers.MultiSelect = false;
            this.dgvEEWorkers.Name = "dgvEEWorkers";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEEWorkers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEEWorkers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEEWorkers.Size = new System.Drawing.Size(1034, 503);
            this.dgvEEWorkers.TabIndex = 2;
            // 
            // comming
            // 
            this.comming.HeaderText = "الغياب";
            this.comming.Name = "comming";
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
            this.btnReject.Location = new System.Drawing.Point(486, 601);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(32, 30);
            this.btnReject.TabIndex = 15;
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
            this.btnAccept.Location = new System.Drawing.Point(533, 601);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(33, 30);
            this.btnAccept.TabIndex = 14;
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // workerCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 639);
            this.ControlBox = false;
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.pnContainer);
            this.Controls.Add(this.eEpNav);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "workerCheck";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الحضور و الغياب";
            ((System.ComponentModel.ISupportInitialize)(this.piExit)).EndInit();
            this.eEpNav.ResumeLayout(false);
            this.pnContainer.ResumeLayout(false);
            this.pnContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEEWorkers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox piExit;
        private System.Windows.Forms.Panel eEpNav;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnContainer;
        public System.Windows.Forms.DataGridView dgvEEWorkers;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.DataGridViewCheckBoxColumn comming;
        private System.Windows.Forms.Label label1;
    }
}