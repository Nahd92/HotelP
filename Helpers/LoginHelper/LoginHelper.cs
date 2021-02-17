using HotelP.Model;
using HotelP.Services;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelP.Helpers.LoginHelper
{
   public static class LoginHelper
    {
        public static bool CheckValidation(string UserName, string Password)
        {
            ISession session = SessionFactoryService.OpenSession;
            using (session)
            {
                try
                {
                    var query = session.CreateQuery("FROM UserLogins WHERE UserName = '" + UserName + "' AND Password = '" + Password + "'");
                    var user = query.List<UserLogins>();
                    if (user.Count > 0)
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                    throw ex;
                }
                return false;
            }

        }
    }
}
