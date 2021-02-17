using HotelP.Model;
using HotelP.Services;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HotelP.Helpers.BookingHelper;
using System.Linq;

namespace HotelP.Forms
{
  
    public partial class BookingForm : Form
    {

        public BookingForm()
        {
            InitializeComponent();
            DisableAllInputs();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {      

          HelperClass.UpdateBooking(int.Parse(tBookingID.Text), int.Parse(tCustomerID.Text), int.Parse(tPaymentsID.Text), int.Parse(tRoomID.Text), 
                  tCheckInDate.Text, tCheckOutDate.Text,
                int.Parse(tNumberOfGuests.Text), tDiscountCode.Text, int.Parse(tNumberOfExtraBeds.Text));
                SetTextBoxesToEmpty();
                    dataGridView1.DataSource = HelperClass.LoadBookingData();       
        }
        private void customerTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var customer = new CustomerForm();
            customer.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ISession session = SessionFactoryService.OpenSession;
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    var bookingData = HelperClass.GetById(tBookingID.Text);
                    if (bookingData != null)
                    {
                        SetTextBoxesToData(bookingData);
                        dataGridView1.DataSource = HelperClass.LoadBookingWithID(bookingData.Booking_ID.ToString());

                        HelperClass.DeleteCustomer(tBookingID.Text);
                        SetTextBoxesToEmpty();
                    }
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    MessageBox.Show("No record found with this id", "No data Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            var bookingData = HelperClass.GetById(id);
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
                        var bookingData = HelperClass.GetById(tBookingID.Text);
                        if (bookingData != null)
                        {
                            SetTextBoxesToData(bookingData);
                            dataGridView1.DataSource = HelperClass.LoadBookingWithID(bookingData.Booking_ID.ToString());
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

        public void DisableAllInputs()
        {
            tBookingDate.Enabled = false;
            tCustomerID.Enabled = false;
            tCheckInDate.Enabled = false;
            tCheckOutDate.Enabled = false;
            tDiscountCode.Enabled = false;
            tRoomID.Enabled = false;
            tPaymentsID.Enabled = false;
            tNumberOfGuests.Enabled = false;
            tTotalCost.Enabled = false;
            tNumberOfExtraBeds.Enabled = false;
        }
        public void EnableAllInputs()
        {
            tBookingDate.Enabled = true;
            tCheckInDate.Enabled = true;
            tCheckOutDate.Enabled = true;
            tDiscountCode.Enabled = true;
            tRoomID.Enabled = true;
            tPaymentsID.Enabled = true;
            tNumberOfGuests.Enabled = true;
            tTotalCost.Enabled = true;
            tCustomerID.Enabled = true;
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

        private void paymentsTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var payments = new PaymentsForm();
            payments.ShowDialog();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
        
           string emptyTextBoxes = string.Join(System.Environment.NewLine,
               (
               from T in this.Controls.OfType<TextBox>()
               where string.IsNullOrWhiteSpace(T.Text)
               select T.Name)
               ).ToArray().ToString();


            HelperClass.CreateBooking(int.Parse(tCustomerID.Text), int.Parse(tPaymentsID.Text), tCheckInDate.Text, tCheckOutDate.Text,
                int.Parse(tNumberOfGuests.Text), tDiscountCode.Text, int.Parse(tNumberOfExtraBeds.Text));

            SetTextBoxesToEmpty();
            dataGridView1.DataSource = HelperClass.LoadBookingData();
        }

        private void CreateCustomerBtn_Click(object sender, EventArgs e)
        {
            var customer = new CustomerForm();
            customer.ShowDialog();
        }

      

        private void CreateBookingBtn_Click(object sender, EventArgs e)
        {
            tBookingDate.Enabled = true;
            tCheckInDate.Enabled = true;
            tCheckOutDate.Enabled = true;
            tDiscountCode.Enabled = true;
            tRoomID.Enabled = false;
            tPaymentsID.Enabled = true;
            tNumberOfGuests.Enabled = true;
            tTotalCost.Enabled = false;
            tCustomerID.Enabled = true;
            tNumberOfExtraBeds.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EnableAllInputs();
        }
    }
}


