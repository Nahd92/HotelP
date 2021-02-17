using HotelP.Model;
using HotelP.Services;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelP.Helpers.RoomsHelper
{
   public class RoomHelper
    {
        public static IList<Rooms> LoadBookingData()
        {
            ISession session = SessionFactoryService.OpenSession;
            using (session)
            {
                IQuery query = session.CreateQuery("FROM Rooms");
                IList<Rooms> bookInfo = query.List<Rooms>();
                return bookInfo;
            }
        }
        public static IList<Rooms> GetById(string id)
        {
            ISession session = SessionFactoryService.OpenSession;
            using (session)
            {
                IQuery query = session.CreateQuery("FROM Rooms WHERE Room_ID = '" + id + "'");
                var bookInfo = query.List<Rooms>();
                return bookInfo;
            }
        }
    }
}
