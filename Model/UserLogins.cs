using System.Collections.Generic;


namespace HotelP.Model
{
    public class UserLogins
    {
        public virtual int Id { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        public virtual string Roles { get; set; }
    }
}
