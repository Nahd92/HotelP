using FluentNHibernate.Mapping;
using HotelP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelP.Mappings
{
    public class UserLoginsMapping : ClassMap<UserLogins>
    {
        public UserLoginsMapping()
        {
            Id(x => x.UserLogins_ID);
            Map(x => x.Username).Not.Nullable();
            Map(x => x.Password).Not.Nullable();
            Table("UserLogins");
        }
    }
}
