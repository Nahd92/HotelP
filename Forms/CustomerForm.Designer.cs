
namespace HotelP.Forms
{
    partial class CustomerForm
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
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facilitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reviewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomDiscountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storedProceduresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fetchAllProceduresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fetchAllQueriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Customer = new System.Windows.Forms.GroupBox();
            this.findBookingBtn = new System.Windows.Forms.Button();
            this.tCustomerId = new System.Windows.Forms.TextBox();
            this.CustomerId = new System.Windows.Forms.Label();
            this.tContactPerson = new System.Windows.Forms.TextBox();
            this.tPhoneNumber = new System.Windows.Forms.TextBox();
            this.tAddress = new System.Windows.Forms.TextBox();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.tLastName = new System.Windows.Forms.TextBox();
            this.tFirstname = new System.Windows.Forms.TextBox();
            this.ContactPerson = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ResetViewButton = new System.Windows.Forms.Button();
            this.LoadAllButton = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.CustomerGridVIew = new System.Windows.Forms.DataGridView();
            this.View = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.Customer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridVIew)).BeginInit();
            this.View.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paymentsTableToolStripMenuItem,
            this.roomTableToolStripMenuItem,
            this.facilitesToolStripMenuItem,
            this.hotelToolStripMenuItem,
            this.paymentsToolStripMenuItem,
            this.reviewsToolStripMenuItem,
            this.roomDiscountToolStripMenuItem,
            this.bookingToolStripMenuItem});
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
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.bookingToolStripMenuItem.Text = "Booking";
            this.bookingToolStripMenuItem.Click += new System.EventHandler(this.bookingToolStripMenuItem_Click);
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
            this.fetchAllProceduresToolStripMenuItem.Click += new System.EventHandler(this.fetchAllProceduresToolStripMenuItem_Click);
            // 
            // queriesToolStripMenuItem
            // 
            this.queriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fetchAllQueriesToolStripMenuItem});
            this.queriesToolStripMenuItem.Name = "queriesToolStripMenuItem";
            this.queriesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.queriesToolStripMenuItem.Text = "Queries";
            this.queriesToolStripMenuItem.Click += new System.EventHandler(this.queriesToolStripMenuItem_Click);
            // 
            // fetchAllQueriesToolStripMenuItem
            // 
            this.fetchAllQueriesToolStripMenuItem.Name = "fetchAllQueriesToolStripMenuItem";
            this.fetchAllQueriesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.fetchAllQueriesToolStripMenuItem.Text = "Fetch all Queries";
            // 
            // Customer
            // 
            this.Customer.Controls.Add(this.findBookingBtn);
            this.Customer.Controls.Add(this.tCustomerId);
            this.Customer.Controls.Add(this.CustomerId);
            this.Customer.Controls.Add(this.tContactPerson);
            this.Customer.Controls.Add(this.tPhoneNumber);
            this.Customer.Controls.Add(this.tAddress);
            this.Customer.Controls.Add(this.tEmail);
            this.Customer.Controls.Add(this.tLastName);
            this.Customer.Controls.Add(this.tFirstname);
            this.Customer.Controls.Add(this.ContactPerson);
            this.Customer.Controls.Add(this.PhoneNumberLabel);
            this.Customer.Controls.Add(this.Address);
            this.Customer.Controls.Add(this.label3);
            this.Customer.Controls.Add(this.label2);
            this.Customer.Controls.Add(this.label1);
            this.Customer.Location = new System.Drawing.Point(12, 27);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(810, 169);
            this.Customer.TabIndex = 9;
            this.Customer.TabStop = false;
            this.Customer.Text = "groupBox1";
            // 
            // findBookingBtn
            // 
            this.findBookingBtn.Location = new System.Drawing.Point(479, 29);
            this.findBookingBtn.Name = "findBookingBtn";
            this.findBookingBtn.Size = new System.Drawing.Size(118, 31);
            this.findBookingBtn.TabIndex = 26;
            this.findBookingBtn.Text = "Find by Id";
            this.findBookingBtn.UseVisualStyleBackColor = true;
            this.findBookingBtn.Click += new System.EventHandler(this.findBookingBtn_Click);
            // 
            // tCustomerId
            // 
            this.tCustomerId.Location = new System.Drawing.Point(364, 35);
            this.tCustomerId.Name = "tCustomerId";
            this.tCustomerId.Size = new System.Drawing.Size(100, 20);
            this.tCustomerId.TabIndex = 43;
            // 
            // CustomerId
            // 
            this.CustomerId.AutoSize = true;
            this.CustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerId.Location = new System.Drawing.Point(280, 39);
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Size = new System.Drawing.Size(78, 16);
            this.CustomerId.TabIndex = 42;
            this.CustomerId.Text = "CustomerID";
            // 
            // tContactPerson
            // 
            this.tContactPerson.Location = new System.Drawing.Point(555, 125);
            this.tContactPerson.Name = "tContactPerson";
            this.tContactPerson.Size = new System.Drawing.Size(100, 20);
            this.tContactPerson.TabIndex = 35;
            // 
            // tPhoneNumber
            // 
            this.tPhoneNumber.Location = new System.Drawing.Point(555, 98);
            this.tPhoneNumber.Name = "tPhoneNumber";
            this.tPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.tPhoneNumber.TabIndex = 34;
            // 
            // tAddress
            // 
            this.tAddress.Location = new System.Drawing.Point(555, 73);
            this.tAddress.Name = "tAddress";
            this.tAddress.Size = new System.Drawing.Size(100, 20);
            this.tAddress.TabIndex = 33;
            // 
            // tEmail
            // 
            this.tEmail.Location = new System.Drawing.Point(309, 129);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(100, 20);
            this.tEmail.TabIndex = 32;
            // 
            // tLastName
            // 
            this.tLastName.Location = new System.Drawing.Point(309, 98);
            this.tLastName.Name = "tLastName";
            this.tLastName.Size = new System.Drawing.Size(100, 20);
            this.tLastName.TabIndex = 31;
            // 
            // tFirstname
            // 
            this.tFirstname.Location = new System.Drawing.Point(309, 70);
            this.tFirstname.Name = "tFirstname";
            this.tFirstname.Size = new System.Drawing.Size(100, 20);
            this.tFirstname.TabIndex = 30;
            // 
            // ContactPerson
            // 
            this.ContactPerson.AutoSize = true;
            this.ContactPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactPerson.Location = new System.Drawing.Point(438, 129);
            this.ContactPerson.Name = "ContactPerson";
            this.ContactPerson.Size = new System.Drawing.Size(99, 16);
            this.ContactPerson.TabIndex = 29;
            this.ContactPerson.Text = "Contact Person";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel.Location = new System.Drawing.Point(438, 98);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(95, 16);
            this.PhoneNumberLabel.TabIndex = 28;
            this.PhoneNumberLabel.Text = "PhoneNumber";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(438, 73);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(59, 16);
            this.Address.TabIndex = 27;
            this.Address.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Lastname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Firstname: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ResetViewButton);
            this.groupBox2.Controls.Add(this.LoadAllButton);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnInsert);
            this.groupBox2.Location = new System.Drawing.Point(12, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(810, 145);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controllers";
            // 
            // ResetViewButton
            // 
            this.ResetViewButton.Location = new System.Drawing.Point(226, 83);
            this.ResetViewButton.Name = "ResetViewButton";
            this.ResetViewButton.Size = new System.Drawing.Size(109, 23);
            this.ResetViewButton.TabIndex = 10;
            this.ResetViewButton.Text = "Reset View";
            this.ResetViewButton.UseVisualStyleBackColor = true;
            this.ResetViewButton.Click += new System.EventHandler(this.ResetViewButton_Click);
            // 
            // LoadAllButton
            // 
            this.LoadAllButton.Location = new System.Drawing.Point(226, 41);
            this.LoadAllButton.Name = "LoadAllButton";
            this.LoadAllButton.Size = new System.Drawing.Size(109, 23);
            this.LoadAllButton.TabIndex = 9;
            this.LoadAllButton.Text = "Load All Customers";
            this.LoadAllButton.UseVisualStyleBackColor = true;
            this.LoadAllButton.Click += new System.EventHandler(this.LoadAllButton_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(570, 64);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(474, 64);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(374, 64);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // CustomerGridVIew
            // 
            this.CustomerGridVIew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGridVIew.Location = new System.Drawing.Point(6, 19);
            this.CustomerGridVIew.Name = "CustomerGridVIew";
            this.CustomerGridVIew.Size = new System.Drawing.Size(798, 215);
            this.CustomerGridVIew.TabIndex = 0;
            // 
            // View
            // 
            this.View.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.View.Controls.Add(this.CustomerGridVIew);
            this.View.Location = new System.Drawing.Point(12, 353);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(810, 240);
            this.View.TabIndex = 10;
            this.View.TabStop = false;
            this.View.Text = "View";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(834, 605);
            this.Controls.Add(this.View);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.menuStrip1);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Customer.ResumeLayout(false);
            this.Customer.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridVIew)).EndInit();
            this.View.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem paymentsTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facilitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reviewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomDiscountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storedProceduresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fetchAllProceduresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fetchAllQueriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.GroupBox Customer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView CustomerGridVIew;
        private System.Windows.Forms.GroupBox View;
        private System.Windows.Forms.Button findBookingBtn;
        private System.Windows.Forms.TextBox tCustomerId;
        private System.Windows.Forms.Label CustomerId;
        private System.Windows.Forms.TextBox tContactPerson;
        private System.Windows.Forms.TextBox tPhoneNumber;
        private System.Windows.Forms.TextBox tAddress;
        private System.Windows.Forms.TextBox tEmail;
        private System.Windows.Forms.TextBox tLastName;
        private System.Windows.Forms.TextBox tFirstname;
        private System.Windows.Forms.Label ContactPerson;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ResetViewButton;
        private System.Windows.Forms.Button LoadAllButton;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
    }
}