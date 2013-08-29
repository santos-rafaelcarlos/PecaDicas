using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using PecaDica.App.Controllers;

namespace PecaDica.App
{
    public static class ContextHelper
    {
        public static void SetLogiCredentials(string UserName, string Password)
        {
            ContextHelper.CategoriaCliente.ClientCredentials.UserName.UserName = UserName;
            ContextHelper.CategoriaCliente.ClientCredentials.UserName.Password = Password;
            ContextHelper.LojaCliente.ClientCredentials.UserName.UserName = UserName;
            ContextHelper.LojaCliente.ClientCredentials.UserName.Password = Password;
            ContextHelper.MarcaCliente.ClientCredentials.UserName.UserName = UserName;
            ContextHelper.MarcaCliente.ClientCredentials.UserName.Password = Password;
            ContextHelper.ModeloCliente.ClientCredentials.UserName.UserName = UserName;
            ContextHelper.ModeloCliente.ClientCredentials.UserName.Password = Password;
            ContextHelper.ProdutoCliente.ClientCredentials.UserName.UserName = UserName;
            ContextHelper.ProdutoCliente.ClientCredentials.UserName.Password = Password;
        }

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

        private static LojaServicos.LojaServiceClient lojaCliente;
        public static LojaServicos.LojaServiceClient LojaCliente
        {
            get
            {
                if (lojaCliente == null)
                    lojaCliente = new LojaServicos.LojaServiceClient();                   
                
                return lojaCliente;
            }
        }

        private static ProdutoServicos.ProdutoServiceClient produtoCliente;
        public static ProdutoServicos.ProdutoServiceClient ProdutoCliente
        {
            get
            {
                if (produtoCliente == null)                
                    produtoCliente = new ProdutoServicos.ProdutoServiceClient();
                 

                return produtoCliente;
            }
        }

        private static ModeloServicos.ModeloServiceClient modeloCliente;
        public static ModeloServicos.ModeloServiceClient ModeloCliente
        {
            get
            {
                if (modeloCliente == null)
                
                    modeloCliente = new ModeloServicos.ModeloServiceClient();
                   

                return modeloCliente;
            }
        }

        private static MarcaServicos.MarcaServiceClient marcaCliente;
        public static MarcaServicos.MarcaServiceClient MarcaCliente
        {
            get
            {
                if (marcaCliente == null)
                
                    marcaCliente = new MarcaServicos.MarcaServiceClient();
                   
                return marcaCliente;
            }
        }

        private static CategoriaServicos.CategoriaServiceClient categoriaCliente;
        public static CategoriaServicos.CategoriaServiceClient CategoriaCliente
        {
            get
            {
                if (categoriaCliente == null)
                
                    categoriaCliente = new CategoriaServicos.CategoriaServiceClient();
                   
                return categoriaCliente;
            }
        }
    }
}