using System.Data.Services;
using System.Data.Services.Common;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using PecaDicas.Nhibernate;
using System.Reflection;

namespace PecaDicas.Services.DataServices
{
    public class ProdutoDataService : DataService<NHDataContext>
    {
        // This method is called only once to initialize service-wide policies.
        public static void InitializeService(DataServiceConfiguration config)
        {
            // TODO: set rules to indicate which entity sets and service operations are visible, updatable, etc.
            // Examples:
            config.SetEntitySetAccessRule("*", EntitySetRights.AllRead);
            // config.SetServiceOperationAccessRule("MyServiceOperation", ServiceOperationRights.All);
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V2;
        }

        NHibernate.ISession session;

        protected override NHDataContext CreateDataSource()
        {
            var factory = CreateSessionFactory();

            this.session = factory.OpenSession();
            this.session.FlushMode = FlushMode.Auto;

            return new NHDataContext(this.session);
        }

        private static ISessionFactory CreateSessionFactory()
        {
            //Todo: Configurar ConnString
            return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008
                .ConnectionString("Data source=.\\SQLExpress;Initial Catalog=Samples;Trusted_Connection=yes")             
                .ShowSql())
                .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.LoadFrom("PecaDicas.Nhibernate")))
                .BuildSessionFactory();
        }
    }
}
