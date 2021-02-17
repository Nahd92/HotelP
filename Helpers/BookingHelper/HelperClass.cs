using HotelP.Model;
using HotelP.Services;
using NHibernate;
using System;
using System.Collections.Generic;

namespace HotelP.Helpers.BookingHelper
{
    public static class HelperClass
    {
        
        public static IList<Booking> LoadBookingWithID(string bookingID)
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
        public static Booking GetById(string id)
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
      

        public static void CreateBooking(int CustomerId, int PaymentsId, 
            string CheckInDate, string CheckOutDate, int NumberOfGuests, 
            string discountCode, int NumberOfExtraBeds)
        {
            ISession session = SessionFactoryService.OpenSession;
            
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    var query = session.CreateSQLQuery(" exec spCreateReservation @Customer_ID=:Customer_ID, @Payments_ID=:Payments_ID, " +
                        " @CheckInDate=:CheckInDate, @CheckOutDate=:CheckOutDate, @NumberOfGuests=:NumberOfGuests, @DiscountCode=:DiscountCode, " +
                        "@NumberOfExtraBeds=:NumberOfExtraBeds ")
                        .SetParameter("Customer_ID", CustomerId)
                        .SetParameter("Payments_ID", PaymentsId)
                        .SetParameter("CheckInDate", CheckInDate)
                        .SetParameter("CheckOutDate", CheckOutDate)
                        .SetParameter("NumberOfGuests", NumberOfGuests)
                        .SetParameter("DiscountCode", discountCode)
                        .SetParameter("NumberOfExtraBeds", NumberOfExtraBeds).ExecuteUpdate();

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
        public static void UpdateBooking(int Booking_ID, int CustomerId, int PaymentsId, int roomId,
            string CheckInDate, string CheckOutDate, int NumberOfGuests,
            string discountCode, int NumberOfExtraBeds)
        {
            ISession session = SessionFactoryService.OpenSession;

            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    var query = session.CreateSQLQuery(" exec spUpdateReservation @Booking_ID=:Booking_ID, @CustomerID=:CustomerID, @Payments_ID=:Payments_ID," +
                        "@Room_ID=:Room_ID, @CheckInDate=:CheckInDate, @CheckOutDate=:CheckOutDate, " +
                        "@NumberOfGuests=:NumberOfGuests, @DiscountCode=:DiscountCode, @NumberOfExtraBeds=:NumberOfExtraBeds ")
                        .SetParameter("Booking_ID", Booking_ID)
                        .SetParameter("CustomerID", CustomerId)
                        .SetParameter("Payments_ID", PaymentsId)
                        .SetParameter("Room_ID", roomId)
                        .SetParameter("CheckInDate", CheckInDate)
                        .SetParameter("CheckOutDate", CheckOutDate)
                        .SetParameter("NumberOfGuests", NumberOfGuests)
                        .SetParameter("DiscountCode", discountCode)
                        .SetParameter("NumberOfExtraBeds", NumberOfExtraBeds)
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
        public static void DeleteCustomer(string bookingID) 
        {
            ISession session = SessionFactoryService.OpenSession;

            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    var query = session.CreateSQLQuery(" exec spDeleteBooking @BookingId=:BookingId")
                        .SetParameter("BookingId", bookingID)
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
