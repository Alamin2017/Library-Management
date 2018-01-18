namespace OutlookMail
{
    partial class LIBRARY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LIBRARY));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mastersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStudentInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudentInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wITHDRAWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dEPOSITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONFIRMSMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLLBOOKINFORMATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mastersToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.transactionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mastersToolStripMenuItem
            // 
            this.mastersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.searchStudentInfoToolStripMenuItem,
            this.updateStudentInfoToolStripMenuItem,
            this.deleteStudentInfoToolStripMenuItem});
            this.mastersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mastersToolStripMenuItem.Name = "mastersToolStripMenuItem";
            this.mastersToolStripMenuItem.Size = new System.Drawing.Size(81, 25);
            this.mastersToolStripMenuItem.Text = "Masters";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.profileToolStripMenuItem.Text = "AddStudentInfo";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // searchStudentInfoToolStripMenuItem
            // 
            this.searchStudentInfoToolStripMenuItem.Name = "searchStudentInfoToolStripMenuItem";
            this.searchStudentInfoToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.searchStudentInfoToolStripMenuItem.Text = "SearchStudentInfo";
            this.searchStudentInfoToolStripMenuItem.Click += new System.EventHandler(this.searchStudentInfoToolStripMenuItem_Click);
            // 
            // updateStudentInfoToolStripMenuItem
            // 
            this.updateStudentInfoToolStripMenuItem.Name = "updateStudentInfoToolStripMenuItem";
            this.updateStudentInfoToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.updateStudentInfoToolStripMenuItem.Text = "UpdateStudentInfo";
            this.updateStudentInfoToolStripMenuItem.Click += new System.EventHandler(this.updateStudentInfoToolStripMenuItem_Click);
            // 
            // deleteStudentInfoToolStripMenuItem
            // 
            this.deleteStudentInfoToolStripMenuItem.Name = "deleteStudentInfoToolStripMenuItem";
            this.deleteStudentInfoToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.deleteStudentInfoToolStripMenuItem.Text = "DeleteStudentInfo";
            this.deleteStudentInfoToolStripMenuItem.Click += new System.EventHandler(this.deleteStudentInfoToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memberToolStripMenuItem,
            this.addBooksToolStripMenuItem,
            this.removeBooksToolStripMenuItem,
            this.updateBooksToolStripMenuItem});
            this.inventoryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(97, 25);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // memberToolStripMenuItem
            // 
            this.memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            this.memberToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.memberToolStripMenuItem.Text = "SearchBooks";
            this.memberToolStripMenuItem.Click += new System.EventHandler(this.memberToolStripMenuItem_Click);
            // 
            // addBooksToolStripMenuItem
            // 
            this.addBooksToolStripMenuItem.Name = "addBooksToolStripMenuItem";
            this.addBooksToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.addBooksToolStripMenuItem.Text = "AddBooks";
            this.addBooksToolStripMenuItem.Click += new System.EventHandler(this.addBooksToolStripMenuItem_Click);
            // 
            // removeBooksToolStripMenuItem
            // 
            this.removeBooksToolStripMenuItem.Name = "removeBooksToolStripMenuItem";
            this.removeBooksToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.removeBooksToolStripMenuItem.Text = "RemoveBooks";
            this.removeBooksToolStripMenuItem.Click += new System.EventHandler(this.removeBooksToolStripMenuItem_Click);
            // 
            // updateBooksToolStripMenuItem
            // 
            this.updateBooksToolStripMenuItem.Name = "updateBooksToolStripMenuItem";
            this.updateBooksToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.updateBooksToolStripMenuItem.Text = "UpdateBooks";
            this.updateBooksToolStripMenuItem.Click += new System.EventHandler(this.updateBooksToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aLLBOOKINFORMATIONToolStripMenuItem});
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(92, 25);
            this.reportsToolStripMenuItem.Text = "BookInfo";
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wITHDRAWToolStripMenuItem,
            this.dEPOSITToolStripMenuItem,
            this.cONFIRMSMSToolStripMenuItem});
            this.transactionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(110, 25);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // wITHDRAWToolStripMenuItem
            // 
            this.wITHDRAWToolStripMenuItem.Name = "wITHDRAWToolStripMenuItem";
            this.wITHDRAWToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.wITHDRAWToolStripMenuItem.Text = "WITHDRAW";
            this.wITHDRAWToolStripMenuItem.Click += new System.EventHandler(this.wITHDRAWToolStripMenuItem_Click);
            // 
            // dEPOSITToolStripMenuItem
            // 
            this.dEPOSITToolStripMenuItem.Name = "dEPOSITToolStripMenuItem";
            this.dEPOSITToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.dEPOSITToolStripMenuItem.Text = "DEPOSIT";
            this.dEPOSITToolStripMenuItem.Click += new System.EventHandler(this.dEPOSITToolStripMenuItem_Click);
            // 
            // cONFIRMSMSToolStripMenuItem
            // 
            this.cONFIRMSMSToolStripMenuItem.Name = "cONFIRMSMSToolStripMenuItem";
            this.cONFIRMSMSToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.cONFIRMSMSToolStripMenuItem.Text = "CONFIRM_SMS";
            this.cONFIRMSMSToolStripMenuItem.Click += new System.EventHandler(this.cONFIRMSMSToolStripMenuItem_Click);
            // 
            // aLLBOOKINFORMATIONToolStripMenuItem
            // 
            this.aLLBOOKINFORMATIONToolStripMenuItem.Name = "aLLBOOKINFORMATIONToolStripMenuItem";
            this.aLLBOOKINFORMATIONToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.aLLBOOKINFORMATIONToolStripMenuItem.Text = "ALL BOOK INFORMATION";
            this.aLLBOOKINFORMATIONToolStripMenuItem.Click += new System.EventHandler(this.aLLBOOKINFORMATIONToolStripMenuItem_Click);
            // 
            // LIBRARY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 607);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LIBRARY";
            this.Text = "LIBRARY";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SIGN_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mastersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStudentInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStudentInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wITHDRAWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dEPOSITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONFIRMSMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLLBOOKINFORMATIONToolStripMenuItem;
    }
}