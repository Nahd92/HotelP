using HotelP.Forms;
using HotelP.Model;
using HotelP.Services;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelP.Helpers
{
    public static class HelperClass
    {


        public static IList<Booking> LoadBookingAfterUpdate(string bookingID)
        {
            ISession session = SessionFactoryService.OpenSession;
            using (session)
            {
                IQuery query = session.CreateQuery("FROM Booking WHERE Booking_ID = '" + bookingID + "'");
                IList<Booking> bookInfo = query.List<Booking>();
                return bookInfo;
            }
        }

        public static IList<Booking> LoadBookingData()
        {
            ISession session = SessionFactoryService.OpenSession;
            using (session)
            {
                IQuery query = session.CreateQuery("FROM Booking");
                IList<Booking> bookInfo = query.List<Booking>();
                return bookInfo;
            }
        }
        public static Booking GetBookingById(string id)
        {
            ISession session = SessionFactoryService.OpenSession;
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    IQuery query = session.CreateQuery("FROM Booking WHERE booking_ID = '" + id + "'");
                    var bookingData = query.List<Booking>()[0];
                    return bookingData;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }






    }
}
