using HotelP.Helpers.PaymentsHelper;
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
    public partial class PaymentsForm : Form
    {
        public PaymentsForm()
        {
            InitializeComponent();
        }

        private void LoadAllButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PaymentsHelper.LoadPaymentsData();          
        }

        private void ResetViewButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (tCardNumber.Text.Length != 16 && tCVV.Text.Length != 3)
            {
                MessageBox.Show("Cardnumber cannot be shorter or longer than 16 digits");
            }
            else
            {
                PaymentsHelper.CreatePayment(int.Parse(tCustomerID.Text), tFirstName.Text, tLastName.Text, tCreditCard.Text,
               tCardNumber.Text, tCVV.Text, tExpirationDate.Text);
            }
            dataGridView1.DataSource = PaymentsHelper.LoadPaymentsData();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6 || e.ColumnIndex == 7)
            {
                if (e.Value != null)
                {
                    e.Value = PaymentsHelper.MaskCardNumberAndCVV(e.Value.ToString());
                    e.FormattingApplied = true;
                }
                else
                    e.FormattingApplied = false;
            }
        }

        private void findBookingBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tPaymentID.Text))
            {
            try
              {
             var paymentData = PaymentsHelper.GetById(tPaymentID.Text);
                if (paymentData != null)
                {
                      SetTextBoxesToData(paymentData);
                      dataGridView1.DataSource = PaymentsHelper.LoadPaymentsWithId(paymentData.Payments_ID.ToString());
                            SetTextBoxesToEmpty();
                }
             }
             catch (Exception)
             {
                        MessageBox.Show("No record found with this id", "No data Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
                
            }
            else
            {
                MessageBox.Show("Please enter booking id ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetTextBoxesToEmpty()
        {
            tCustomerID.Text = "";
            tFirstName.Text = "";
            tLastName.Text = "";
            tCreditCard.Text = "";
            tCardNumber.Text = "";
            tCVV.Text = "";
            tExpirationDate.Text = "";
        }

        private void SetTextBoxesToData(Payments payments)
        {
            tCustomerID.Text = payments.Customer_ID.ToString();
            tFirstName.Text = payments.FirstName.ToString();
            tLastName.Text = payments.LastName.ToString();
            tCreditCard.Text = payments.CreditCard.ToString();
            tCardNumber.Text = payments.CardNumber.ToString();
            tCVV.Text = payments.CVV.ToString();
            tExpirationDate.Text = payments.ExpirationDate.ToString();
        }
    }
}
