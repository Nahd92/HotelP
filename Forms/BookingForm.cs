using HotelP.Model;
using HotelP.Services;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HotelP.Helpers;

namespace HotelP.Forms
{
  
    public partial class BookingForm : Form
    {
        public BookingForm(UserLogins userLogins)
        {
            InitializeComponent();
            if (userLogins.Roles == "Guest")
            {
                btnUpdate.Visible = false;
                btnDelete.Visible = false;             
            }
        }


        private void LoadAllButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = HelperClass.LoadBookingData();
        }
      
        private void ResetView(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";
            SetTextBoxesToEmpty();
        }

      
        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = HelperClass.LoadBookingData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ISession session = SessionFactoryService.OpenSession;

            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    IQuery query = session.CreateQuery("FROM Booking WHERE booking_ID = '" + tBookingID.Text + "'");
                    transaction.Commit();

                    dataGridView1.DataSource = HelperClass.LoadBookingData();

                    SetTextBoxesToEmpty();

                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                    throw ex;
                }
            }
        }

    
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount <= 1 || e.RowIndex <= 0)
                return;
            string id = dataGridView1[0, e.RowIndex].Value.ToString();
            if (id == "")
                return;

            var bookingData = HelperClass.GetBookingById(id);
            SetTextBoxesToData(bookingData);
        }

        private void findBookingBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tBookingID.Text))
            {
                ISession session = SessionFactoryService.OpenSession;
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        var bookingData = HelperClass.GetBookingById(tBookingID.Text);
                        if (bookingData != null)
                        {
                            SetTextBoxesToData(bookingData);
                            dataGridView1.DataSource = HelperClass.LoadBookingAfterUpdate(bookingData.Booking_ID.ToString());
                        }
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        MessageBox.Show("No record found with this id", "No data Found", MessageBoxButtons.OK, MessageBoxIcon.Information);                      
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter booking id ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetTextBoxesToEmpty()
        {
            tBookingID.Text = "";
            tCustomerID.Text = "";
            tBookingDate.Text = "";
            tCheckInDate.Text = "";
            tCheckOutDate.Text = "";
            tPaymentsID.Text = "";
            tDiscountCode.Text = "";
            tRoomID.Text = "";
            tNumberOfGuests.Text = "";
            tTotalCost.Text = "";
        }
        private void SetTextBoxesToData(Booking booking)
        {
            tCustomerID.Text = booking.Customer_ID.ToString();
            tBookingDate.Text = booking.BookingDate.ToString();
            tCheckInDate.Text = booking.CheckInDate.ToString();
            tCheckOutDate.Text = booking.CheckOutDate.ToString();
            tPaymentsID.Text = booking.Payments_ID.ToString();
            tDiscountCode.Text = booking.DiscountCode.ToString();
            tRoomID.Text = booking.Room_ID.ToString();
            tNumberOfGuests.Text = booking.NumberOfGuests.ToString();
            tTotalCost.Text = booking.TotalCost.ToString();
        }
        //Set booking
        private void SetBookingData(Booking booking)
        {
            booking.Customer_ID = int.Parse(tCustomerID.Text);
            booking.Payments_ID = int.Parse(tPaymentsID.Text);
            booking.Room_ID = int.Parse(tRoomID.Text);
            booking.BookingDate = DateTime.Parse(tBookingDate.Text);
            booking.CheckInDate = DateTime.Parse(tCheckInDate.Text);
            booking.CheckOutDate = DateTime.Parse(tCheckOutDate.Text);
            booking.DiscountCode = tDiscountCode.Text;
            booking.NumberOfGuests = int.Parse(tNumberOfGuests.Text);
            booking.TotalCost = int.Parse(tTotalCost.Text);
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            var login = new Login();
            login.Show();
            Hide();
        }

        private void fetchAllProceduresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var spForm = new StoredProcedure();
            spForm.ShowDialog();
        }

        private void fetchAllQueriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var queries = new Queries();
            queries.ShowDialog();
        }
    }
}
