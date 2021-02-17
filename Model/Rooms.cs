using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelP.Model
{
    public class Rooms
    {
        public virtual int Room_Id { get; set; }
        public virtual int RoomNumber { get; set; }
        public virtual int CustomerMax { get; set; }
        public virtual bool Avaliable { get; set; }
        public virtual int Cost { get; set; }
    }
}
