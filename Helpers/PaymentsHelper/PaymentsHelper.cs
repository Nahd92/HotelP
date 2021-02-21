using HotelP.Model;
using HotelP.Services;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelP.Helpers.PaymentsHelper
{
    public static class PaymentsHelper 
    {

        public static Payments GetById(string id)
        {
            var session = SessionFactoryService.OpenSession;
            using (session)
            {
                var query = session.CreateQuery("FROM Payments WHERE Payments_ID = '"+ id +"'");
                var payments = query.List<Payments>()[0];
                return payments;
            }
        }
        public static IList<Payments> LoadPaymentsData()
        {
            ISession session = SessionFactoryService.OpenSession;
            using (session)
            {
                IQuery query = session.CreateQuery("FROM Payments");
                IList<Payments> payments = query.List<Payments>();
                return payments;
            }
        }

        public static  void CreatePayment(int CustomerId, string FirstName, string LastName, string Creditcard, string CardNumber, string Cvv, string ExpirationDate)
        {
            ISession session = SessionFactoryService.OpenSession;

            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    var query = session.CreateSQLQuery(" exec spCreatePayments @Customer_ID=:Customer_ID, @FirstName=:FirstName, " +
                        " @LastName=:LastName, @CreditCard=:CreditCard, @CardNumber=:CardNumber, @CVV=:CVV," +
                        " @ExpirationDate=:ExpirationDate")
                        .SetParameter("Customer_ID", CustomerId)
                        .SetParameter("FirstName", FirstName)
                        .SetParameter("LastName", LastName)
                        .SetParameter("CreditCard", Creditcard)
                        .SetParameter("CardNumber", CardNumber)
                        .SetParameter("CVV", Cvv)
                        .SetParameter("ExpirationDate", ExpirationDate).ExecuteUpdate();

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

        public static IList<Payments> LoadPaymentsWithId(string Id)
        {
            ISession session = SessionFactoryService.OpenSession;
            using (session)
            {
                IQuery query = session.CreateQuery("FROM Payments WHERE Payments_ID = '" + Id + "'");
                IList<Payments> paymentInfo = query.List<Payments>();
                return paymentInfo;
            }
        }

            public static string MaskCardNumberAndCVV(string number)
            {
                var maskedPan = number.Replace(number, "*********");

                return maskedPan;
            }
    }
}
 