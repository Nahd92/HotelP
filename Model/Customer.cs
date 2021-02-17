using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelP.Model
{
    public class Customer
    {
        public virtual int Customer_ID { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Address { get; set; }
        public virtual string Email { get; set; }
        public virtual int PhoneNumber { get; set; }
        public virtual string ContactPerson { get; set; }
    }
}
