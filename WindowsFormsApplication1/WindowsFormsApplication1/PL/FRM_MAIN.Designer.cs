namespace WindowsFormsApplication1.PL
{
    partial class FRM_MAIN
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAUVGARDEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rESTOREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWPRODUCTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANAGEMENTPRODUCTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mANAGEMENTCATEGORIESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWCUSTOMERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANAGMENTCUSTOMERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.nEWPURCHASEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANAGEMENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWUSERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANAGMENTUSERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONFIGURATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.productToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(560, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem,
            this.sAUVGARDEToolStripMenuItem,
            this.rESTOREToolStripMenuItem,
            this.lOGOUTToolStripMenuItem,
            this.cONFIGURATIONToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "&Menu";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.logInToolStripMenuItem.Text = "&LOGIN";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // sAUVGARDEToolStripMenuItem
            // 
            this.sAUVGARDEToolStripMenuItem.Name = "sAUVGARDEToolStripMenuItem";
            this.sAUVGARDEToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.sAUVGARDEToolStripMenuItem.Text = "&SAUAVEGARDE";
            this.sAUVGARDEToolStripMenuItem.Click += new System.EventHandler(this.sAUVGARDEToolStripMenuItem_Click);
            // 
            // rESTOREToolStripMenuItem
            // 
            this.rESTOREToolStripMenuItem.Name = "rESTOREToolStripMenuItem";
            this.rESTOREToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.rESTOREToolStripMenuItem.Text = "&RESTORE";
            this.rESTOREToolStripMenuItem.Click += new System.EventHandler(this.rESTOREToolStripMenuItem_Click);
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.lOGOUTToolStripMenuItem.Text = "&LOGOUT";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWPRODUCTToolStripMenuItem,
            this.mANAGEMENTPRODUCTToolStripMenuItem,
            this.toolStripSeparator1,
            this.mANAGEMENTCATEGORIESToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.productToolStripMenuItem.Text = "&Products";
            // 
            // nEWPRODUCTToolStripMenuItem
            // 
            this.nEWPRODUCTToolStripMenuItem.Name = "nEWPRODUCTToolStripMenuItem";
            this.nEWPRODUCTToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.nEWPRODUCTToolStripMenuItem.Text = "&NEW PRODUCT";
            this.nEWPRODUCTToolStripMenuItem.Click += new System.EventHandler(this.nEWPRODUCTToolStripMenuItem_Click);
            // 
            // mANAGEMENTPRODUCTToolStripMenuItem
            // 
            this.mANAGEMENTPRODUCTToolStripMenuItem.Name = "mANAGEMENTPRODUCTToolStripMenuItem";
            this.mANAGEMENTPRODUCTToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.mANAGEMENTPRODUCTToolStripMenuItem.Text = "&MANAGEMENT PRODUCT";
            this.mANAGEMENTPRODUCTToolStripMenuItem.Click += new System.EventHandler(this.mANAGEMENTPRODUCTToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(217, 6);
            // 
            // mANAGEMENTCATEGORIESToolStripMenuItem
            // 
            this.mANAGEMENTCATEGORIESToolStripMenuItem.Name = "mANAGEMENTCATEGORIESToolStripMenuItem";
            this.mANAGEMENTCATEGORIESToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.mANAGEMENTCATEGORIESToolStripMenuItem.Text = "&MANAGEMENT CATEGORY";
            this.mANAGEMENTCATEGORIESToolStripMenuItem.Click += new System.EventHandler(this.mANAGEMENTCATEGORIESToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWCUSTOMERToolStripMenuItem,
            this.mANAGMENTCUSTOMERToolStripMenuItem,
            this.toolStripSeparator2,
            this.nEWPURCHASEToolStripMenuItem,
            this.mANAGEMENTToolStripMenuItem});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.customersToolStripMenuItem.Text = "&Customers";
            // 
            // nEWCUSTOMERToolStripMenuItem
            // 
            this.nEWCUSTOMERToolStripMenuItem.Name = "nEWCUSTOMERToolStripMenuItem";
            this.nEWCUSTOMERToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.nEWCUSTOMERToolStripMenuItem.Text = "&NEW CUSTOMER";
            // 
            // mANAGMENTCUSTOMERToolStripMenuItem
            // 
            this.mANAGMENTCUSTOMERToolStripMenuItem.Name = "mANAGMENTCUSTOMERToolStripMenuItem";
            this.mANAGMENTCUSTOMERToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.mANAGMENTCUSTOMERToolStripMenuItem.Text = "&MANAGMENT CUSTOMER";
            this.mANAGMENTCUSTOMERToolStripMenuItem.Click += new System.EventHandler(this.mANAGMENTCUSTOMERToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(219, 6);
            // 
            // nEWPURCHASEToolStripMenuItem
            // 
            this.nEWPURCHASEToolStripMenuItem.Name = "nEWPURCHASEToolStripMenuItem";
            this.nEWPURCHASEToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.nEWPURCHASEToolStripMenuItem.Text = "&NEW PURCHASE";
            this.nEWPURCHASEToolStripMenuItem.Click += new System.EventHandler(this.nEWPURCHASEToolStripMenuItem_Click);
            // 
            // mANAGEMENTToolStripMenuItem
            // 
            this.mANAGEMENTToolStripMenuItem.Name = "mANAGEMENTToolStripMenuItem";
            this.mANAGEMENTToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.mANAGEMENTToolStripMenuItem.Text = "&MANAGEMENT  PURCHASE";
            this.mANAGEMENTToolStripMenuItem.Click += new System.EventHandler(this.mANAGEMENTToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWUSERToolStripMenuItem,
            this.mANAGMENTUSERSToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "&Users";
            // 
            // nEWUSERToolStripMenuItem
            // 
            this.nEWUSERToolStripMenuItem.Name = "nEWUSERToolStripMenuItem";
            this.nEWUSERToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.nEWUSERToolStripMenuItem.Text = "&NEW USER";
            this.nEWUSERToolStripMenuItem.Click += new System.EventHandler(this.nEWUSERToolStripMenuItem_Click);
            // 
            // mANAGMENTUSERSToolStripMenuItem
            // 
            this.mANAGMENTUSERSToolStripMenuItem.Name = "mANAGMENTUSERSToolStripMenuItem";
            this.mANAGMENTUSERSToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.mANAGMENTUSERSToolStripMenuItem.Text = "&MANAGMENT USERS";
            this.mANAGMENTUSERSToolStripMenuItem.Click += new System.EventHandler(this.mANAGMENTUSERSToolStripMenuItem_Click);
            // 
            // cONFIGURATIONToolStripMenuItem
            // 
            this.cONFIGURATIONToolStripMenuItem.Name = "cONFIGURATIONToolStripMenuItem";
            this.cONFIGURATIONToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.cONFIGURATIONToolStripMenuItem.Text = "&CONFIGURATION";
            this.cONFIGURATIONToolStripMenuItem.Click += new System.EventHandler(this.cONFIGURATIONToolStripMenuItem_Click);
            // 
            // FRM_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 331);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_MAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU FORMS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_MAIN_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem sAUVGARDEToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem rESTOREToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem nEWPRODUCTToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem mANAGEMENTPRODUCTToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem mANAGEMENTCATEGORIESToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem nEWCUSTOMERToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem mANAGMENTCUSTOMERToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem nEWPURCHASEToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem mANAGEMENTToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem nEWUSERToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem mANAGMENTUSERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONFIGURATIONToolStripMenuItem;
    }
}