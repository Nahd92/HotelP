using HotelP.Model;
using HotelP.Services;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelP.Helpers.CustomerHelper
{
    public class CustomerHelper
    {


        public static IList<Customer> LoadBookingWithID(string CustomerId)
        {
            ISession session = SessionFactoryService.OpenSession;
            using (session)
            {
                IQuery query = session.CreateQuery("FROM Customer WHERE Customer_ID = '" + CustomerId + "'");
                IList<Customer> bookInfo = query.List<Customer>();
                return bookInfo;
            }
        }
        public static IList<Customer> LoadBookingData()
        {
            ISession session = SessionFactoryService.OpenSession;
            using (session)
            {
                IQuery query = session.CreateQuery("FROM Customer");
                IList<Customer> bookInfo = query.List<Customer>();
                return bookInfo;
            }
        }
        public static Customer GetById(string id)
        {
            ISession session = SessionFactoryService.OpenSession;
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    IQuery query = session.CreateQuery("FROM Customer WHERE Customer_ID = '" + id + "'");
                    var bookingData = query.List<Customer>()[0];
                    return bookingData;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public static void CreateCustomer(string FirstName, string Lastname,
            string Email, string Address, int PhoneNumber, string ContactPerson)
        {
            ISession session = SessionFactoryService.OpenSession;

            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    var query = session.CreateSQLQuery(" exec spCreateCustomer @FirstName=:FirstName, @LastName=:LastName, " +
                        " @Email=:Email, @Address=:Address, @PhoneNumber=:PhoneNumber, @ContactPerson=:ContactPerson")
                        .SetParameter("FirstName", FirstName)
                        .SetParameter("LastName", Lastname)
                        .SetParameter("Email", Email)
                        .SetParameter("Address", Address)
                        .SetParameter("PhoneNumber", PhoneNumber)
                        .SetParameter("ContactPerson", ContactPerson)
                        .ExecuteUpdate();

                    transaction.Commit();

                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                    throw ex;
                }
            }
        }

        public static void DeleteCustomer(int Customer_ID)
        {
            ISession session = SessionFactoryService.OpenSession;

            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    var query = session.CreateSQLQuery(" exec spDeleteCustomer @CustomerID=:Customer_ID")
                        .SetParameter("Customer_ID", Customer_ID)
                        .ExecuteUpdate();

                    transaction.Commit();

                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                    throw ex;
                }
            }
        }




        public static void UpdateCustomer(int Customer_ID, string FirstName, string Lastname, string Email, string Address,
       string PhoneNumber, string ContactPerson)
        {
            ISession session = SessionFactoryService.OpenSession;

            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    var query = session.CreateSQLQuery(" exec spUpdateCustomer @CustomerID=:Customer_ID, @FirstName=:FirstName, " +
                        " @LastName=:LastName, @Email=:Email, @Address=:Address, @PhoneNumber=:PhoneNumber, @ContactPerson=:ContactPerson")
                        .SetParameter("Customer_ID", Customer_ID)
                        .SetParameter("FirstName", FirstName)
                        .SetParameter("LastName", Lastname)
                        .SetParameter("Email", Email)
                        .SetParameter("Address", Address)
                        .SetParameter("PhoneNumber", PhoneNumber)
                        .SetParameter("ContactPerson", ContactPerson)
                        .ExecuteUpdate();

                    transaction.Commit();

                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                    throw ex;
                }
            }
        }

    }
}
