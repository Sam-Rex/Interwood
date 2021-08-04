namespace EOM_stores.Ul.Operations
{
    partial class eeReciveOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReciveSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEEReciveOrder = new System.Windows.Forms.DataGridView();
            this.eEpNav = new System.Windows.Forms.Panel();
            this.piExit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEEReciveOrder)).BeginInit();
            this.eEpNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtReciveSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvEEReciveOrder);
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 585);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(847, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "أدخل رقم اذن الاستلام:";
            // 
            // txtReciveSearch
            // 
            this.txtReciveSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReciveSearch.Location = new System.Drawing.Point(543, 63);
            this.txtReciveSearch.Name = "txtReciveSearch";
            this.txtReciveSearch.Size = new System.Drawing.Size(300, 25);
            this.txtReciveSearch.TabIndex = 5;
            this.txtReciveSearch.TextChanged += new System.EventHandler(this.txtReciveSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "أذونات الاستلام";
            // 
            // dgvEEReciveOrder
            // 
            this.dgvEEReciveOrder.AllowUserToAddRows = false;
            this.dgvEEReciveOrder.AllowUserToDeleteRows = false;
            this.dgvEEReciveOrder.AllowUserToResizeColumns = false;
            this.dgvEEReciveOrder.AllowUserToResizeRows = false;
            this.dgvEEReciveOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEEReciveOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEEReciveOrder.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvEEReciveOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEEReciveOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEEReciveOrder.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEEReciveOrder.Location = new System.Drawing.Point(6, 94);
            this.dgvEEReciveOrder.MultiSelect = false;
            this.dgvEEReciveOrder.Name = "dgvEEReciveOrder";
            this.dgvEEReciveOrder.ReadOnly = true;
            this.dgvEEReciveOrder.RowTemplate.Height = 32;
            this.dgvEEReciveOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEEReciveOrder.Size = new System.Drawing.Size(1040, 458);
            this.dgvEEReciveOrder.TabIndex = 1;
            this.dgvEEReciveOrder.DoubleClick += new System.EventHandler(this.dgvEEReciveOrder_DoubleClick);
            // 
            // eEpNav
            // 
            this.eEpNav.BackgroundImage = global::EOM_stores.Properties.Resources.navigatiopn21;
            this.eEpNav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eEpNav.Controls.Add(this.piExit);
            this.eEpNav.Controls.Add(this.panel2);
            this.eEpNav.Controls.Add(this.panel3);
            this.eEpNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.eEpNav.Location = new System.Drawing.Point(0, 0);
            this.eEpNav.Name = "eEpNav";
            this.eEpNav.Size = new System.Drawing.Size(1050, 29);
            this.eEpNav.TabIndex = 7;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(3, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Location = new System.Drawing.Point(3, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 1;
            // 
            // eeReciveOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 639);
            this.ControlBox = false;
            this.Controls.Add(this.eEpNav);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "eeReciveOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "أذونات الإستلام";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEEReciveOrder)).EndInit();
            this.eEpNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.piExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox piExit;
        private System.Windows.Forms.Panel eEpNav;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dgvEEReciveOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReciveSearch;
    }
}