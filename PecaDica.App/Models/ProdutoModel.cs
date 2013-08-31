using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PecaDica.App.Models
{
    public class ProdutoModel : DataServ.Produto
    {
        private string categoriaName;
        public string CategoriaName 
        {
            get
            {
                try
                {
                    if (string.IsNullOrEmpty(categoriaName))
                        categoriaName = ContextHelper.Contexto.Categoria.Where(c => c.Id == this.CategoriaID).FirstOrDefault().Nome;
                    return categoriaName;
                }
                catch { return string.Empty; }
            }
        }

        private string modeloName;
        public string ModeloName
        {
            get
            {
                try
                {
                    if (string.IsNullOrEmpty(modeloName))
                        modeloName = ContextHelper.Contexto.Modelo.Where(c => c.Id == this.ModeloID).FirstOrDefault().Nome;
                    return modeloName;
                }
                catch { return string.Empty; }
            }
        }
    }
}