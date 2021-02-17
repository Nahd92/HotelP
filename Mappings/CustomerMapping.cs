using FluentNHibernate.Mapping;
using HotelP.Model;

namespace HotelP.Mappings
{
   public class CustomerMapping : ClassMap<Customer>
    {
        public CustomerMapping()
        {
            Id(x => x.Customer_ID);
            Map(x => x.FirstName).Not.Nullable();
            Map(x => x.LastName).Not.Nullable();
            Map(x => x.Address).Not.Nullable();
            Map(x => x.Email).Not.Nullable();
            Map(x => x.PhoneNumber).Not.Nullable();
            Map(x => x.ContactPerson).Not.Nullable();
            Table("Customer");
        }
    }
}
