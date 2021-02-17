
namespace HotelP.Forms
{
    partial class RoomsForm
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
            this.customerTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.roomgridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadAllButton = new System.Windows.Forms.Button();
            this.ResetViewButton = new System.Windows.Forms.Button();
            this.idBtn = new System.Windows.Forms.Button();
            this.tidTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomgridView)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(654, 24);
            this.menuStrip1.TabIndex = 10;
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
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paymentsTableToolStripMenuItem,
            this.customerTableToolStripMenuItem,
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
            this.paymentsTableToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.paymentsTableToolStripMenuItem.Text = "Payments";
            this.paymentsTableToolStripMenuItem.Click += new System.EventHandler(this.paymentsTableToolStripMenuItem_Click);
            // 
            // customerTableToolStripMenuItem
            // 
            this.customerTableToolStripMenuItem.Name = "customerTableToolStripMenuItem";
            this.customerTableToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.customerTableToolStripMenuItem.Text = "Customers";
            this.customerTableToolStripMenuItem.Click += new System.EventHandler(this.customerTableToolStripMenuItem_Click);
            // 
            // facilitesToolStripMenuItem
            // 
            this.facilitesToolStripMenuItem.Name = "facilitesToolStripMenuItem";
            this.facilitesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.facilitesToolStripMenuItem.Text = "Facilites";
            // 
            // hotelToolStripMenuItem
            // 
            this.hotelToolStripMenuItem.Name = "hotelToolStripMenuItem";
            this.hotelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hotelToolStripMenuItem.Text = "Hotel";
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.paymentsToolStripMenuItem.Text = "Staffs";
            // 
            // reviewsToolStripMenuItem
            // 
            this.reviewsToolStripMenuItem.Name = "reviewsToolStripMenuItem";
            this.reviewsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reviewsToolStripMenuItem.Text = "Reviews";
            // 
            // roomDiscountToolStripMenuItem
            // 
            this.roomDiscountToolStripMenuItem.Name = "roomDiscountToolStripMenuItem";
            this.roomDiscountToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.roomDiscountToolStripMenuItem.Text = "Room Discount";
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            // 
            // fetchAllQueriesToolStripMenuItem
            // 
            this.fetchAllQueriesToolStripMenuItem.Name = "fetchAllQueriesToolStripMenuItem";
            this.fetchAllQueriesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fetchAllQueriesToolStripMenuItem.Text = "Fetch all Queries";
            this.fetchAllQueriesToolStripMenuItem.Click += new System.EventHandler(this.fetchAllQueriesToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.roomgridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 526);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rooms";
            // 
            // roomgridView
            // 
            this.roomgridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.roomgridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomgridView.Location = new System.Drawing.Point(6, 19);
            this.roomgridView.Name = "roomgridView";
            this.roomgridView.Size = new System.Drawing.Size(618, 501);
            this.roomgridView.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 55);
            this.label1.TabIndex = 12;
            this.label1.Text = "Rooms";
            // 
            // LoadAllButton
            // 
            this.LoadAllButton.Location = new System.Drawing.Point(96, 125);
            this.LoadAllButton.Name = "LoadAllButton";
            this.LoadAllButton.Size = new System.Drawing.Size(116, 45);
            this.LoadAllButton.TabIndex = 13;
            this.LoadAllButton.Text = "Load All Rooms";
            this.LoadAllButton.UseVisualStyleBackColor = true;
            this.LoadAllButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResetViewButton
            // 
            this.ResetViewButton.Location = new System.Drawing.Point(246, 125);
            this.ResetViewButton.Name = "ResetViewButton";
            this.ResetViewButton.Size = new System.Drawing.Size(115, 45);
            this.ResetViewButton.TabIndex = 14;
            this.ResetViewButton.Text = "Reset View";
            this.ResetViewButton.UseVisualStyleBackColor = true;
            this.ResetViewButton.Click += new System.EventHandler(this.ResetViewButton_Click);
            // 
            // idBtn
            // 
            this.idBtn.Location = new System.Drawing.Point(411, 125);
            this.idBtn.Name = "idBtn";
            this.idBtn.Size = new System.Drawing.Size(111, 45);
            this.idBtn.TabIndex = 15;
            this.idBtn.Text = "Find by ID";
            this.idBtn.UseVisualStyleBackColor = true;
            this.idBtn.Click += new System.EventHandler(this.idBtn_Click);
            // 
            // tidTextBox
            // 
            this.tidTextBox.Location = new System.Drawing.Point(537, 138);
            this.tidTextBox.Multiline = true;
            this.tidTextBox.Name = "tidTextBox";
            this.tidTextBox.Size = new System.Drawing.Size(76, 24);
            this.tidTextBox.TabIndex = 16;
            // 
            // RoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(654, 731);
            this.Controls.Add(this.tidTextBox);
            this.Controls.Add(this.idBtn);
            this.Controls.Add(this.ResetViewButton);
            this.Controls.Add(this.LoadAllButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "RoomsForm";
            this.Text = "RoomsForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomgridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem paymentsTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facilitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reviewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomDiscountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storedProceduresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fetchAllProceduresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fetchAllQueriesToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView roomgridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoadAllButton;
        private System.Windows.Forms.Button ResetViewButton;
        private System.Windows.Forms.Button idBtn;
        private System.Windows.Forms.TextBox tidTextBox;
    }
}