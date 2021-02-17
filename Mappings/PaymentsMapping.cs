using FluentNHibernate.Mapping;
using HotelP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelP.Mappings
{
    public class PaymentsMapping : ClassMap<Payments>
    {
        public PaymentsMapping()
        {
            Id(x => x.Payments_ID);
            Map(c => c.Customer).Column("Customer_ID").Not.LazyLoad();
            Map(x => x.FirstName).Not.Nullable();
            Map(x => x.LastName).Not.Nullable();
            Map(x => x.CreditCard).Not.Nullable();
            Map(x => x.Date).Not.Nullable();
            Map(x => x.CardNumber).Not.Nullable();
            Map(x => x.CVV).Not.Nullable();
            Map(x => x.ExpirationDate).Not.Nullable();
            Table("Payments");
        }
    }
}
