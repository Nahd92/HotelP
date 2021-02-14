using FluentNHibernate.Mapping;
using HotelP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelP.Mappings
{
    public class UserMapping : ClassMap<UserLogins>
    {
        public UserMapping()
        {
            Id(x => x.Id);
            Map(x => x.UserName).Not.Nullable();
            Map(x => x.Password).Not.Nullable();
            Map(x => x.Roles).Not.Nullable();
            Table("UserLogins");
        
        }
 
    }
}
