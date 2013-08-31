using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PecaDica.App.Models
{
    public class ModeloModel : DataServ.Modelo
    {
        private string marcaName;
        public string MarcaName 
        {
            get
            {
                try
                {
                    if (string.IsNullOrEmpty(marcaName))
                        marcaName = ContextHelper.Contexto.Marca.Where(c => c.Id == this.MarcaID).FirstOrDefault().Nome;
                    return marcaName;
                }
                catch { return string.Empty; }
            }
        }
    }
}