﻿
namespace HotelP.Forms
{
    partial class BookingForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.CreateBookingBtn = new System.Windows.Forms.Button();
            this.ResetViewButton = new System.Windows.Forms.Button();
            this.LoadAllButton = new System.Windows.Forms.Button();
            this.CreateCustomerBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PaymentBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tNumberOfExtraBeds = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.findBookingBtn = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tBookingID = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tTotalCost = new System.Windows.Forms.TextBox();
            this.tDiscountCode = new System.Windows.Forms.TextBox();
            this.tBookingDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tNumberOfGuests = new System.Windows.Forms.TextBox();
            this.tCheckOutDate = new System.Windows.Forms.TextBox();
            this.tCheckInDate = new System.Windows.Forms.TextBox();
            this.tPaymentsID = new System.Windows.Forms.TextBox();
            this.tRoomID = new System.Windows.Forms.TextBox();
            this.tCustomerID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 359);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1243, 326);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "View";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1243, 307);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.CreateBookingBtn);
            this.groupBox2.Location = new System.Drawing.Point(460, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(795, 105);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(95, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(264, 20);
            this.label14.TabIndex = 23;
            this.label14.Text = "Click Button to enable correct inputs";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(616, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "Update booking";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CreateBookingBtn
            // 
            this.CreateBookingBtn.Location = new System.Drawing.Point(458, 36);
            this.CreateBookingBtn.Name = "CreateBookingBtn";
            this.CreateBookingBtn.Size = new System.Drawing.Size(98, 44);
            this.CreateBookingBtn.TabIndex = 4;
            this.CreateBookingBtn.Text = "Create booking";
            this.CreateBookingBtn.UseVisualStyleBackColor = true;
            this.CreateBookingBtn.Click += new System.EventHandler(this.CreateBookingBtn_Click);
            // 
            // ResetViewButton
            // 
            this.ResetViewButton.Location = new System.Drawing.Point(214, 62);
            this.ResetViewButton.Name = "ResetViewButton";
            this.ResetViewButton.Size = new System.Drawing.Size(140, 48);
            this.ResetViewButton.TabIndex = 5;
            this.ResetViewButton.Text = "Reset View";
            this.ResetViewButton.UseVisualStyleBackColor = true;
            this.ResetViewButton.Click += new System.EventHandler(this.ResetView);
            // 
            // LoadAllButton
            // 
            this.LoadAllButton.Location = new System.Drawing.Point(47, 62);
            this.LoadAllButton.Name = "LoadAllButton";
            this.LoadAllButton.Size = new System.Drawing.Size(132, 48);
            this.LoadAllButton.TabIndex = 4;
            this.LoadAllButton.Text = "Load All Bookings";
            this.LoadAllButton.UseVisualStyleBackColor = true;
            this.LoadAllButton.Click += new System.EventHandler(this.LoadAllButton_Click);
            // 
            // CreateCustomerBtn
            // 
            this.CreateCustomerBtn.Location = new System.Drawing.Point(40, 57);
            this.CreateCustomerBtn.Name = "CreateCustomerBtn";
            this.CreateCustomerBtn.Size = new System.Drawing.Size(140, 38);
            this.CreateCustomerBtn.TabIndex = 22;
            this.CreateCustomerBtn.Text = "Create Customer";
            this.CreateCustomerBtn.UseVisualStyleBackColor = true;
            this.CreateCustomerBtn.Click += new System.EventHandler(this.CreateCustomerBtn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(241, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "Do you need to create a Customer first?";
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
            this.menuStrip1.Size = new System.Drawing.Size(1267, 24);
            this.menuStrip1.TabIndex = 7;
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
            this.paymentsTableToolStripMenuItem.Click += new System.EventHandler(this.paymentsTableToolStripMenuItem_Click);
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
            this.customerTableToolStripMenuItem.Click += new System.EventHandler(this.customerTableToolStripMenuItem_Click);
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
            this.fetchAllProceduresToolStripMenuItem.Click += new System.EventHandler(this.fetchAllProceduresToolStripMenuItem_Click);
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
            this.fetchAllQueriesToolStripMenuItem.Click += new System.EventHandler(this.fetchAllQueriesToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PaymentBtn);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.CreateCustomerBtn);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(17, 37);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(437, 155);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Create new?";
            // 
            // PaymentBtn
            // 
            this.PaymentBtn.Location = new System.Drawing.Point(249, 92);
            this.PaymentBtn.Name = "PaymentBtn";
            this.PaymentBtn.Size = new System.Drawing.Size(148, 37);
            this.PaymentBtn.TabIndex = 24;
            this.PaymentBtn.Text = "Create Payment";
            this.PaymentBtn.UseVisualStyleBackColor = true;
            this.PaymentBtn.Click += new System.EventHandler(this.PaymentBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(259, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 18);
            this.label11.TabIndex = 25;
            this.label11.Text = "Create payment?";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ResetViewButton);
            this.groupBox5.Controls.Add(this.LoadAllButton);
            this.groupBox5.Location = new System.Drawing.Point(18, 198);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(436, 155);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Load or Reset";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tNumberOfExtraBeds);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.findBookingBtn);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.tBookingID);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tTotalCost);
            this.groupBox1.Controls.Add(this.tDiscountCode);
            this.groupBox1.Controls.Add(this.tBookingDate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tNumberOfGuests);
            this.groupBox1.Controls.Add(this.tCheckOutDate);
            this.groupBox1.Controls.Add(this.tCheckInDate);
            this.groupBox1.Controls.Add(this.tPaymentsID);
            this.groupBox1.Controls.Add(this.tRoomID);
            this.groupBox1.Controls.Add(this.tCustomerID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(460, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 205);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Booking";
            // 
            // tNumberOfExtraBeds
            // 
            this.tNumberOfExtraBeds.Location = new System.Drawing.Point(507, 115);
            this.tNumberOfExtraBeds.Name = "tNumberOfExtraBeds";
            this.tNumberOfExtraBeds.Size = new System.Drawing.Size(100, 20);
            this.tNumberOfExtraBeds.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(414, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Extra beds";
            // 
            // findBookingBtn
            // 
            this.findBookingBtn.Location = new System.Drawing.Point(203, 16);
            this.findBookingBtn.Name = "findBookingBtn";
            this.findBookingBtn.Size = new System.Drawing.Size(118, 31);
            this.findBookingBtn.TabIndex = 4;
            this.findBookingBtn.Text = "Find by Id";
            this.findBookingBtn.UseVisualStyleBackColor = true;
            this.findBookingBtn.Click += new System.EventHandler(this.findBookingBtn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(458, 155);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 33);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tBookingID
            // 
            this.tBookingID.Location = new System.Drawing.Point(88, 22);
            this.tBookingID.Name = "tBookingID";
            this.tBookingID.Size = new System.Drawing.Size(100, 20);
            this.tBookingID.TabIndex = 20;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(203, 155);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(98, 33);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(326, 155);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 33);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "BookingID";
            // 
            // tTotalCost
            // 
            this.tTotalCost.Location = new System.Drawing.Point(674, 89);
            this.tTotalCost.Name = "tTotalCost";
            this.tTotalCost.Size = new System.Drawing.Size(100, 20);
            this.tTotalCost.TabIndex = 18;
            // 
            // tDiscountCode
            // 
            this.tDiscountCode.Location = new System.Drawing.Point(507, 85);
            this.tDiscountCode.Name = "tDiscountCode";
            this.tDiscountCode.Size = new System.Drawing.Size(100, 20);
            this.tDiscountCode.TabIndex = 17;
            // 
            // tBookingDate
            // 
            this.tBookingDate.Location = new System.Drawing.Point(507, 60);
            this.tBookingDate.Name = "tBookingDate";
            this.tBookingDate.Size = new System.Drawing.Size(100, 20);
            this.tBookingDate.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(613, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Total Cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(414, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "DiscountCode";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(414, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "BookingDate";
            // 
            // tNumberOfGuests
            // 
            this.tNumberOfGuests.Location = new System.Drawing.Point(292, 112);
            this.tNumberOfGuests.Name = "tNumberOfGuests";
            this.tNumberOfGuests.Size = new System.Drawing.Size(100, 20);
            this.tNumberOfGuests.TabIndex = 12;
            // 
            // tCheckOutDate
            // 
            this.tCheckOutDate.Location = new System.Drawing.Point(292, 85);
            this.tCheckOutDate.Name = "tCheckOutDate";
            this.tCheckOutDate.Size = new System.Drawing.Size(100, 20);
            this.tCheckOutDate.TabIndex = 11;
            // 
            // tCheckInDate
            // 
            this.tCheckInDate.Location = new System.Drawing.Point(292, 60);
            this.tCheckInDate.Name = "tCheckInDate";
            this.tCheckInDate.Size = new System.Drawing.Size(100, 20);
            this.tCheckInDate.TabIndex = 10;
            // 
            // tPaymentsID
            // 
            this.tPaymentsID.Location = new System.Drawing.Point(88, 116);
            this.tPaymentsID.Name = "tPaymentsID";
            this.tPaymentsID.Size = new System.Drawing.Size(100, 20);
            this.tPaymentsID.TabIndex = 9;
            // 
            // tRoomID
            // 
            this.tRoomID.Location = new System.Drawing.Point(88, 85);
            this.tRoomID.Name = "tRoomID";
            this.tRoomID.Size = new System.Drawing.Size(100, 20);
            this.tRoomID.TabIndex = 8;
            // 
            // tCustomerID
            // 
            this.tCustomerID.Location = new System.Drawing.Point(88, 57);
            this.tCustomerID.Name = "tCustomerID";
            this.tCustomerID.Size = new System.Drawing.Size(100, 20);
            this.tCustomerID.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "NumberOfGuests";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "CheckOutDate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "CheckInDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "PaymentsID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "RoomID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CustomerID";
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1267, 697);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BookingForm";
            this.Text = "BookingForm";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button LoadAllButton;
        private System.Windows.Forms.Button ResetViewButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem paymentsTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storedProceduresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fetchAllQueriesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem facilitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reviewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomDiscountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fetchAllProceduresToolStripMenuItem;
        private System.Windows.Forms.Button CreateCustomerBtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button CreateBookingBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button PaymentBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tNumberOfExtraBeds;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button findBookingBtn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tBookingID;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tTotalCost;
        private System.Windows.Forms.TextBox tDiscountCode;
        private System.Windows.Forms.TextBox tBookingDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tNumberOfGuests;
        private System.Windows.Forms.TextBox tCheckOutDate;
        private System.Windows.Forms.TextBox tCheckInDate;
        private System.Windows.Forms.TextBox tPaymentsID;
        private System.Windows.Forms.TextBox tRoomID;
        private System.Windows.Forms.TextBox tCustomerID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}