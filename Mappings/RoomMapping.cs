using FluentNHibernate.Mapping;
using HotelP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelP.Mappings
{
    public class RoomMapping : ClassMap<Rooms>
    {

        public RoomMapping()
        {
            Id(x => x.Room_Id);
            Map(x => x.RoomNumber).Not.Nullable();
            Map(x => x.CustomerMax).Not.Nullable();
            Map(x => x.Avaliable).Not.Nullable();
            Map(x => x.Cost).Not.Nullable();
        }
    }
}
