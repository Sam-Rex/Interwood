namespace EOM_stores.Rpt
{
    partial class rptContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptContainer));
            this.reportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.piExit = new System.Windows.Forms.PictureBox();
            this.eEpNav = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.piExit)).BeginInit();
            this.eEpNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.ActiveViewIndex = -1;
            this.reportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportViewer.Location = new System.Drawing.Point(0, 28);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(1034, 572);
            this.reportViewer.TabIndex = 0;
            this.reportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
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
            this.eEpNav.Controls.Add(this.panel3);
            this.eEpNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.eEpNav.Location = new System.Drawing.Point(0, 0);
            this.eEpNav.Name = "eEpNav";
            this.eEpNav.Size = new System.Drawing.Size(1034, 29);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Location = new System.Drawing.Point(3, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 1;
            // 
            // rptContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 600);
            this.ControlBox = false;
            this.Controls.Add(this.eEpNav);
            this.Controls.Add(this.reportViewer);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rptContainer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.Text = "طباعة";
            ((System.ComponentModel.ISupportInitialize)(this.piExit)).EndInit();
            this.eEpNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer reportViewer;
        private System.Windows.Forms.PictureBox piExit;
        private System.Windows.Forms.Panel eEpNav;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}