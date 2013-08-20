using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PecaDica.App
{
    public static class ContextHelper
    {
        private static PecaDicaServicos.PecaDicaBDEntities contexto;
        public static PecaDicaServicos.PecaDicaBDEntities Contexto
        {
            get 
            {
                if (contexto == null) 
                    contexto = new PecaDicaServicos
                        .PecaDicaBDEntities(new Uri("http://localhost:63962/DataServices/ModelDataService.svc/"));

                return contexto;
            }
        }
    }
}