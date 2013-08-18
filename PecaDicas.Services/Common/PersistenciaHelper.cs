using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PecaDicas.Services.DataServices;
using System.Data;

namespace PecaDicas.Services.Common
{
    internal static class PersistenciaHelper
    {
        private static string ConnString =
    System.Configuration.ConfigurationManager.ConnectionStrings["PecaDicaBDEntities"].ConnectionString;
            
//@"metadata=res://*/DataServices.PecaDicaEntities.csdl|res://*/DataServices.PecaDicaEntities.ssdl|res://*/DataServices.PecaDicaEntities.msl;provider=System.Data.SqlClient;provider connection string=""Data Source=.\sqlExpress;Initial Catalog=pecaDicaBD;integrated security=False;multipleactiveresultsets=True;App=EntityFramework";
       // private const string sqlConnString = @"Server=.\sqlExpress;Database=pecaDicaBD;Integrated Security=True";

        //String.Format("metadata=res://*/ReportingEDM.csdl|res://*/ReportingEDM.ssdl|res://*/ReportingEDM.msl;provider=System.Data.SqlClient;provider connection string=""Data Source=<<DBServerName>>;Initial Catalog=<<DBName>>;User ID=<<username>>;Password=<<password>>!;MultipleActiveResultSets=True"" provider Name=System.Data.EntityClient")
        private static PecaDica.Modelo.PecaDicaBDEntities instance;
        internal static PecaDica.Modelo.PecaDicaBDEntities Instance
        {
            get
            {
                if (instance == null)
                    instance = new PecaDica.Modelo.PecaDicaBDEntities();
                //new System.Data.EntityClient.EntityConnection(ConnString));
                return instance;
            }
        }

        internal static Object GetItem(string typeName, Guid id)
        {
            return Instance.GetObjectByKey(CreateEntityKey(typeName, id));
        }

        private static EntityKey CreateEntityKey(string typeName, Guid id)
        {
            IEnumerable<KeyValuePair<string, object>> entityKeyValues = new KeyValuePair<string, object>[] 
                 { 
                     new KeyValuePair<string, object>("Id", id)
                 };

            EntityKey key = new EntityKey(string.Format("pecaDicaBDEntities.{0}", typeName), entityKeyValues);

            return key;
        }
    }
}