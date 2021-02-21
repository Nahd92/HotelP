using FluentNHibernate.Mapping;
using HotelP.Model;

namespace HotelP.Mappings
{
    public class BookingMapping : ClassMap<Booking>
    {
        public BookingMapping()
        {
            Id(x => x.Booking_ID);
            Map(x => x.Customer_ID).Not.Nullable();
            Map(x => x.Payments_ID).Not.Nullable();
            Map(x => x.Room_ID).Not.Nullable();
            Map(x => x.CheckInDate).Not.Nullable();
            Map(x => x.CheckOutDate).Not.Nullable();
            Map(x => x.NumberOfGuests).Not.Nullable();
            Map(x => x.BookingDate).Not.Nullable();
            Map(x => x.DiscountCode).Not.Nullable();
            Map(x => x.TotalCost).Not.Nullable();
            Map(x => x.NumberOfExtraBeds).Not.Nullable();            
            Table("Booking");
        }
    }
}
