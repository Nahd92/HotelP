using HotelP.Forms;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            PwdtBox.PasswordChar = '*';
            PwdtBox.MaxLength = 10;

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            ISession session = SessionFactoryService.OpenSession;
            using (session)
            {
                var query = session.Query<UserLogins>()
                                    .Where(reg => reg.UserName == UsertBox.Text && reg.Password == PwdtBox.Text
                                    && reg.Roles == "Admin" || reg.Roles == "Guest")
                                    .FirstOrDefault();




                if (string.IsNullOrEmpty(UsertBox.Text))
                {
                    MessageBox.Show("UserName cannot be empty or null");
                }
                if (string.IsNullOrEmpty(PwdtBox.Text))
                {
                    MessageBox.Show("Password cannot be empty or null");
                }
                else
                {
                    var bookingForm = new BookingForm(query);
                    MessageBox.Show("Successfully logged in!");
                    bookingForm.Show();
                    Hide();
                }

              
            }
           
        }

    
    }
}
