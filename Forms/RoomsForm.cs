using HotelP.Helpers.RoomsHelper;
using HotelP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelP.Forms
{
    public partial class RoomsForm : Form
    {
        public RoomsForm()
        {
            InitializeComponent();
        }




































        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var booking = new BookingForm();
            booking.Show();
            this.Hide();
        }

        private void paymentsTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var payments = new PaymentsForm();
            payments.Show();
            this.Hide();
        }

        private void customerTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var customers = new CustomerForm();
            customers.Show();
            this.Hide();
        }

        private void fetchAllProceduresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var stored = new StoredProcedure();
            stored.ShowDialog();
            this.Hide();
        }

        private void fetchAllQueriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var quires = new Queries();
            quires.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            roomgridView.DataSource = RoomHelper.LoadBookingData();
        }

        private void idBtn_Click(object sender, EventArgs e)
        {
            roomgridView.DataSource = RoomHelper.GetById(tidTextBox.Text);
       
        }

        private void ResetViewButton_Click(object sender, EventArgs e)
        {
            roomgridView.DataSource = "";
        }

       
    }
}
