using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelP.Model
{
    public class Booking 
    {
        public virtual int Booking_ID { get; set; }
        public virtual int Customer_ID { get; set; }
        public virtual int Payments_ID { get; set; }
        public virtual int Room_ID { get; set; }
        public virtual DateTime CheckInDate { get; set; }
        public virtual DateTime CheckOutDate { get; set; }
        public virtual int NumberOfGuests { get; set; }
        public virtual DateTime BookingDate { get; set; }
        public virtual string DiscountCode { get; set; }
        public virtual int TotalCost { get; set; }
        public virtual int NumberOfExtraBeds { get; set; }




    }
}
