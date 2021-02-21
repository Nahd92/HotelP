using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelP.Model
{
   public class Payments
    {
        public virtual int Payments_ID { get; set; }
        public virtual int Customer_ID { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string CreditCard { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual string CardNumber { get; set; }
        public virtual string CVV { get; set; }
        public virtual string ExpirationDate { get; set; }

    }
}
