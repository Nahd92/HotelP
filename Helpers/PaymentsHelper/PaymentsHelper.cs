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
            throw new NotImplementedException();
        }

        public static IList<Payments> LoadPayments()
        {
            ISession session = SessionFactoryService.OpenSession;
            using (session)
            {
                IQuery query = session.CreateQuery("FROM Payments");
                IList<Payments> bookInfo = query.List<Payments>();
                return bookInfo;
            }
        }

        public static IList<Payments> LoadPaymentsWithId(string Id)
        {
            throw new NotImplementedException();
        }
    }
}
