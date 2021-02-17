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
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var booking = new BookingForm();
            booking.ShowDialog();
        }

        private void paymentsTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var payments = new PaymentsForm();
            payments.ShowDialog();
        }

        private void fetchAllProceduresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var storedProcedures = new StoredProcedure();
            storedProcedures.ShowDialog();
        }

        private void queriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var quires = new Queries();
            quires.ShowDialog();
        }

        private void customerTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var customer = new CustomerForm();
            customer.Show();
            this.Hide();
        }
    }
}
