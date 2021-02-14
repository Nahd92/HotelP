using HotelP.Model;
using HotelP.Services;
using NHibernate;
using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

namespace HotelP.Helpers.StoredProcedure
{
    public class SPHelpers
    {
        public static List<string> GetAllStoredProceduresNames()
        {
            var storedProcedure = new List<string>();
            ISession session = SessionFactoryService.OpenSession;
            using (session)
            {
                var query = session.CreateSQLQuery("SELECT [Name] FROM [dbo].[sysobjects] WHERE [XType] = 'P'");
                var bookInfo = query.List<string>();
                try
                {
                    foreach (var qur in bookInfo)
                    {
                        storedProcedure.Add(qur.ToString());
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }
               
            }
            return storedProcedure;
        }

        public static List<string> GetStoredProcedureContent(string pName)
        {
            List<string> contents = new List<string>();
            ISession session = SessionFactoryService.OpenSession;
            using (session)
            {
                var stringQuery = "SELECT definition FROM sys.sql_modules  " +
                                     $"WHERE [object_id] = OBJECT_ID('dbo.{pName}');";
                var query = session.CreateSQLQuery(stringQuery);
                var bookInfo = query.List<string>();
           
                foreach (var con in bookInfo)
                {
                    contents.Add(con);
                }
            }

            return contents;
        }
    }
}
