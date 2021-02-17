
namespace HotelP.Forms
{
    partial class PaymentsForm
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facilitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reviewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomDiscountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storedProceduresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fetchAllProceduresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fetchAllQueriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.findBookingBtn = new System.Windows.Forms.Button();
            this.tBookingID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tExpirationDate = new System.Windows.Forms.TextBox();
            this.ExipirationLabel = new System.Windows.Forms.Label();
            this.tCVV = new System.Windows.Forms.TextBox();
            this.tDate = new System.Windows.Forms.TextBox();
            this.tCreditCard = new System.Windows.Forms.TextBox();
            this.tLastName = new System.Windows.Forms.TextBox();
            this.tFirstName = new System.Windows.Forms.TextBox();
            this.tCustomerID = new System.Windows.Forms.TextBox();
            this.CVVLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.CreditCard = new System.Windows.Forms.Label();
            this.LastNameLabe = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ResetViewButton = new System.Windows.Forms.Button();
            this.LoadAllButton = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.storedProceduresToolStripMenuItem,
            this.queriesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(977, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.openToolStripMenuItem.Text = "Open MSSM";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paymentsTableToolStripMenuItem,
            this.roomTableToolStripMenuItem,
            this.customerTableToolStripMenuItem,
            this.facilitesToolStripMenuItem,
            this.hotelToolStripMenuItem,
            this.paymentsToolStripMenuItem,
            this.reviewsToolStripMenuItem,
            this.roomDiscountToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem2.Text = "View";
            // 
            // paymentsTableToolStripMenuItem
            // 
            this.paymentsTableToolStripMenuItem.Name = "paymentsTableToolStripMenuItem";
            this.paymentsTableToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.paymentsTableToolStripMenuItem.Text = "Payments";
            // 
            // roomTableToolStripMenuItem
            // 
            this.roomTableToolStripMenuItem.Name = "roomTableToolStripMenuItem";
            this.roomTableToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.roomTableToolStripMenuItem.Text = "Rooms";
            // 
            // customerTableToolStripMenuItem
            // 
            this.customerTableToolStripMenuItem.Name = "customerTableToolStripMenuItem";
            this.customerTableToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.customerTableToolStripMenuItem.Text = "Customers";
            // 
            // facilitesToolStripMenuItem
            // 
            this.facilitesToolStripMenuItem.Name = "facilitesToolStripMenuItem";
            this.facilitesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.facilitesToolStripMenuItem.Text = "Facilites";
            // 
            // hotelToolStripMenuItem
            // 
            this.hotelToolStripMenuItem.Name = "hotelToolStripMenuItem";
            this.hotelToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.hotelToolStripMenuItem.Text = "Hotel";
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.paymentsToolStripMenuItem.Text = "Staffs";
            // 
            // reviewsToolStripMenuItem
            // 
            this.reviewsToolStripMenuItem.Name = "reviewsToolStripMenuItem";
            this.reviewsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.reviewsToolStripMenuItem.Text = "Reviews";
            // 
            // roomDiscountToolStripMenuItem
            // 
            this.roomDiscountToolStripMenuItem.Name = "roomDiscountToolStripMenuItem";
            this.roomDiscountToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.roomDiscountToolStripMenuItem.Text = "Room Discount";
            // 
            // storedProceduresToolStripMenuItem
            // 
            this.storedProceduresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fetchAllProceduresToolStripMenuItem});
            this.storedProceduresToolStripMenuItem.Name = "storedProceduresToolStripMenuItem";
            this.storedProceduresToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.storedProceduresToolStripMenuItem.Text = "Stored Procedures";
            // 
            // fetchAllProceduresToolStripMenuItem
            // 
            this.fetchAllProceduresToolStripMenuItem.Name = "fetchAllProceduresToolStripMenuItem";
            this.fetchAllProceduresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fetchAllProceduresToolStripMenuItem.Text = "Fetch all Procedures";
            // 
            // queriesToolStripMenuItem
            // 
            this.queriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fetchAllQueriesToolStripMenuItem});
            this.queriesToolStripMenuItem.Name = "queriesToolStripMenuItem";
            this.queriesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.queriesToolStripMenuItem.Text = "Queries";
            // 
            // fetchAllQueriesToolStripMenuItem
            // 
            this.fetchAllQueriesToolStripMenuItem.Name = "fetchAllQueriesToolStripMenuItem";
            this.fetchAllQueriesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.fetchAllQueriesToolStripMenuItem.Text = "Fetch all Queries";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.findBookingBtn);
            this.groupBox1.Controls.Add(this.tBookingID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tExpirationDate);
            this.groupBox1.Controls.Add(this.ExipirationLabel);
            this.groupBox1.Controls.Add(this.tCVV);
            this.groupBox1.Controls.Add(this.tDate);
            this.groupBox1.Controls.Add(this.tCreditCard);
            this.groupBox1.Controls.Add(this.tLastName);
            this.groupBox1.Controls.Add(this.tFirstName);
            this.groupBox1.Controls.Add(this.tCustomerID);
            this.groupBox1.Controls.Add(this.CVVLabel);
            this.groupBox1.Controls.Add(this.DateLabel);
            this.groupBox1.Controls.Add(this.CreditCard);
            this.groupBox1.Controls.Add(this.LastNameLabe);
            this.groupBox1.Controls.Add(this.FirstNameLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(953, 148);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payments";
            // 
            // findBookingBtn
            // 
            this.findBookingBtn.Location = new System.Drawing.Point(455, 22);
            this.findBookingBtn.Name = "findBookingBtn";
            this.findBookingBtn.Size = new System.Drawing.Size(118, 31);
            this.findBookingBtn.TabIndex = 25;
            this.findBookingBtn.Text = "Find by Id";
            this.findBookingBtn.UseVisualStyleBackColor = true;
            // 
            // tBookingID
            // 
            this.tBookingID.Location = new System.Drawing.Point(340, 28);
            this.tBookingID.Name = "tBookingID";
            this.tBookingID.Size = new System.Drawing.Size(100, 20);
            this.tBookingID.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(272, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "PaymentsID";
            // 
            // tExpirationDate
            // 
            this.tExpirationDate.Location = new System.Drawing.Point(545, 122);
            this.tExpirationDate.Name = "tExpirationDate";
            this.tExpirationDate.Size = new System.Drawing.Size(100, 20);
            this.tExpirationDate.TabIndex = 37;
            // 
            // ExipirationLabel
            // 
            this.ExipirationLabel.AutoSize = true;
            this.ExipirationLabel.Location = new System.Drawing.Point(452, 122);
            this.ExipirationLabel.Name = "ExipirationLabel";
            this.ExipirationLabel.Size = new System.Drawing.Size(76, 13);
            this.ExipirationLabel.TabIndex = 34;
            this.ExipirationLabel.Text = "ExpirationDate";
            // 
            // tCVV
            // 
            this.tCVV.Location = new System.Drawing.Point(695, 63);
            this.tCVV.Name = "tCVV";
            this.tCVV.Size = new System.Drawing.Size(100, 20);
            this.tCVV.TabIndex = 33;
            // 
            // tDate
            // 
            this.tDate.Location = new System.Drawing.Point(544, 91);
            this.tDate.Name = "tDate";
            this.tDate.Size = new System.Drawing.Size(100, 20);
            this.tDate.TabIndex = 32;
            // 
            // tCreditCard
            // 
            this.tCreditCard.Location = new System.Drawing.Point(544, 66);
            this.tCreditCard.Name = "tCreditCard";
            this.tCreditCard.Size = new System.Drawing.Size(100, 20);
            this.tCreditCard.TabIndex = 31;
            // 
            // tLastName
            // 
            this.tLastName.Location = new System.Drawing.Point(340, 122);
            this.tLastName.Name = "tLastName";
            this.tLastName.Size = new System.Drawing.Size(100, 20);
            this.tLastName.TabIndex = 30;
            // 
            // tFirstName
            // 
            this.tFirstName.Location = new System.Drawing.Point(340, 91);
            this.tFirstName.Name = "tFirstName";
            this.tFirstName.Size = new System.Drawing.Size(100, 20);
            this.tFirstName.TabIndex = 29;
            // 
            // tCustomerID
            // 
            this.tCustomerID.Location = new System.Drawing.Point(340, 59);
            this.tCustomerID.Name = "tCustomerID";
            this.tCustomerID.Size = new System.Drawing.Size(100, 20);
            this.tCustomerID.TabIndex = 28;
            // 
            // CVVLabel
            // 
            this.CVVLabel.AutoSize = true;
            this.CVVLabel.Location = new System.Drawing.Point(661, 70);
            this.CVVLabel.Name = "CVVLabel";
            this.CVVLabel.Size = new System.Drawing.Size(28, 13);
            this.CVVLabel.TabIndex = 27;
            this.CVVLabel.Text = "CVV";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(452, 94);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(30, 13);
            this.DateLabel.TabIndex = 26;
            this.DateLabel.Text = "Date";
            // 
            // CreditCard
            // 
            this.CreditCard.AutoSize = true;
            this.CreditCard.Location = new System.Drawing.Point(452, 66);
            this.CreditCard.Name = "CreditCard";
            this.CreditCard.Size = new System.Drawing.Size(56, 13);
            this.CreditCard.TabIndex = 24;
            this.CreditCard.Text = "CreditCard";
            // 
            // LastNameLabe
            // 
            this.LastNameLabe.AutoSize = true;
            this.LastNameLabe.Location = new System.Drawing.Point(272, 125);
            this.LastNameLabe.Name = "LastNameLabe";
            this.LastNameLabe.Size = new System.Drawing.Size(55, 13);
            this.LastNameLabe.TabIndex = 23;
            this.LastNameLabe.Text = "LastName";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(272, 98);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(54, 13);
            this.FirstNameLabel.TabIndex = 22;
            this.FirstNameLabel.Text = "FirstName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "CustomerID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ResetViewButton);
            this.groupBox2.Controls.Add(this.LoadAllButton);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnInsert);
            this.groupBox2.Location = new System.Drawing.Point(12, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(953, 130);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controls";
            // 
            // ResetViewButton
            // 
            this.ResetViewButton.Location = new System.Drawing.Point(243, 82);
            this.ResetViewButton.Name = "ResetViewButton";
            this.ResetViewButton.Size = new System.Drawing.Size(109, 23);
            this.ResetViewButton.TabIndex = 10;
            this.ResetViewButton.Text = "Reset View";
            this.ResetViewButton.UseVisualStyleBackColor = true;
            this.ResetViewButton.Click += new System.EventHandler(this.ResetViewButton_Click);
            // 
            // LoadAllButton
            // 
            this.LoadAllButton.Location = new System.Drawing.Point(243, 36);
            this.LoadAllButton.Name = "LoadAllButton";
            this.LoadAllButton.Size = new System.Drawing.Size(109, 23);
            this.LoadAllButton.TabIndex = 9;
            this.LoadAllButton.Text = "Load All Payments";
            this.LoadAllButton.UseVisualStyleBackColor = true;
            this.LoadAllButton.Click += new System.EventHandler(this.LoadAllButton_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(594, 63);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(498, 63);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(398, 63);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 317);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(953, 296);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "View";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(945, 271);
            this.dataGridView1.TabIndex = 0;
            // 
            // PaymentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(977, 625);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "PaymentsForm";
            this.Text = "Payments";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem paymentsTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facilitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reviewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomDiscountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storedProceduresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fetchAllProceduresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fetchAllQueriesToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button findBookingBtn;
        private System.Windows.Forms.TextBox tBookingID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tExpirationDate;
        private System.Windows.Forms.Label ExipirationLabel;
        private System.Windows.Forms.TextBox tCVV;
        private System.Windows.Forms.TextBox tDate;
        private System.Windows.Forms.TextBox tCreditCard;
        private System.Windows.Forms.TextBox tLastName;
        private System.Windows.Forms.TextBox tFirstName;
        private System.Windows.Forms.TextBox tCustomerID;
        private System.Windows.Forms.Label CVVLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label CreditCard;
        private System.Windows.Forms.Label LastNameLabe;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ResetViewButton;
        private System.Windows.Forms.Button LoadAllButton;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
    }
}