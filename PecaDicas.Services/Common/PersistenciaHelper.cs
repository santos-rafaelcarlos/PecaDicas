using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PecaDicas.Services.DataServices;
using System.Data;
using PecaDicas.Contratos.Common;
using System.Configuration;

namespace PecaDicas.Services.Common
{
    internal static class PersistenciaHelper
    {
        private static string ConnString = ConfigurationManager.ConnectionStrings["PecaDicaBDEntities"].ConnectionString;

        private static PecaDicaBDEntities instance;
        internal static PecaDicaBDEntities Instance
        {
            get
            {
                if (instance == null)
                    instance = new PecaDicaBDEntities();
                
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