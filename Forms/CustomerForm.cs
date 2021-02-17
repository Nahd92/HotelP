using HotelP.Helpers.CustomerHelper;
using HotelP.Model;
using HotelP.Services;
using NHibernate;
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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void queriesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var queries = new Queries();
            queries.ShowDialog();
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var booking = new BookingForm();
            booking.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fetchAllProceduresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var spForm = new StoredProcedure();
            spForm.ShowDialog();
        }

        private void findBookingBtn_Click(object sender, EventArgs e)
        {         
            if (!string.IsNullOrEmpty(tCustomerId.Text))
            {
                ISession session = SessionFactoryService.OpenSession;
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        var customerData = CustomerHelper.GetById(tCustomerId.Text);
                        if (customerData != null)
                        {
                            SetTextBoxesToData(customerData);
                            CustomerGridVIew.DataSource = CustomerHelper.LoadBookingWithID(customerData.Customer_ID.ToString());
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ISession session = SessionFactoryService.OpenSession;
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    var customerData = CustomerHelper.GetById(tCustomerId.Text);
                    if (customerData != null)
                    {
                        SetTextBoxesToData(customerData);
                        CustomerGridVIew.DataSource = CustomerHelper.LoadBookingWithID(customerData.Customer_ID.ToString());

                        CustomerHelper.DeleteCustomer(int.Parse(tCustomerId.Text));
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            CustomerHelper.CreateCustomer(tFirstname.Text, tLastName.Text, tEmail.Text, tAddress.Text, int.Parse(tPhoneNumber.Text),
                tContactPerson.Text);

            SetTextBoxesToEmpty();
            CustomerGridVIew.DataSource = CustomerHelper.LoadBookingData();

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CustomerHelper.UpdateCustomer(int.Parse(tCustomerId.Text),tFirstname.Text, tLastName.Text, tEmail.Text, tAddress.Text, tPhoneNumber.Text, tContactPerson.Text);

            SetTextBoxesToEmpty();
            CustomerGridVIew.DataSource = CustomerHelper.LoadBookingData();
        }

        private void LoadAllButton_Click(object sender, EventArgs e)
        {
            CustomerGridVIew.DataSource = CustomerHelper.LoadBookingData();
        }
        private void ResetViewButton_Click(object sender, EventArgs e)
        {
            CustomerGridVIew.DataSource = "";
        }





        private void SetTextBoxesToEmpty()
        {
            tAddress.Text = "";
            tContactPerson.Text = "";
            tCustomerId.Text = "";
            tEmail.Text = "";
            tFirstname.Text = "";
            tLastName.Text = "";
            tPhoneNumber.Text = "";
        }
        private void SetTextBoxesToData(Customer customer)
        {
            tFirstname.Text = customer.FirstName.ToString();
            tLastName.Text = customer.LastName.ToString();
            tContactPerson.Text = customer.ContactPerson.ToString();
            tAddress.Text = customer.Address.ToString();
            tEmail.Text = customer.Email.ToString();
            tPhoneNumber.Text = customer.PhoneNumber.ToString();
        }

        
    }
}
