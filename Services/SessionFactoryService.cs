using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HotelP.Services
{
   public class SessionFactoryService
    {
        private static volatile ISessionFactory _sessionFactory;
        private static object syncRoot = new Object();

        public SessionFactoryService() => _sessionFactory = BuildSessionFactory();

        public static ISession OpenSession
        {
            get
            {
                if (_sessionFactory == null)
                {
                    lock(syncRoot)
                    if (_sessionFactory == null)
                    {
                            _sessionFactory = BuildSessionFactory();
                    }
                }
                return _sessionFactory.OpenSession();
            }
        }

        private static ISessionFactory BuildSessionFactory()
        {
            try
            {
                string connectionString = @"Server=(localdb)\mssqllocaldb; Database =TestDB; Trusted_Connection = True; User = Test; Password = hej";

                return Fluently.Configure()
                     .Database(MsSqlConfiguration.MsSql2012
                     .ConnectionString(connectionString))
                     .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Program>())
                     .ExposeConfiguration(BuildSchema)
                     .BuildSessionFactory(); 
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                throw ex;
                
            }
        }

        private static AutoPersistenceModel CreateMapping()
        {
            return AutoMap
                .Assembly(Assembly.GetCallingAssembly())
                .Where(testc => testc.Namespace == "HotelP.Model");
        }
        private static void BuildSchema(NHibernate.Cfg.Configuration config) 
        { 

        }
    }
}
