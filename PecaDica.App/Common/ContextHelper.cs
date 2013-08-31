using System;
using System.ServiceModel;
using System.Security.Cryptography.X509Certificates;

namespace PecaDica.App
{
    public static class ContextHelper
    {
        #region Categoria

        public static void InsertCategoria(CatServ.Categoria item)
        {
            WSHttpBinding binding = new WSHttpBinding();
            binding.Security.Mode = SecurityMode.Message;
            binding.Security.Message.ClientCredentialType =
                MessageCredentialType.UserName;
            binding.Security.Message.NegotiateServiceCredential = false;

            using (var client = new CatServ.CategoriaServiceClient())
            {
                if (client.ClientCredentials != null)
                    client.ClientCredentials
                        .ServiceCertificate
                        .SetDefaultCertificate(StoreLocation.LocalMachine,
                                               StoreName.My,
                                               X509FindType.FindBySubjectName,
                                               "CertificadoPD");
                client.ClientCredentials.UserName.UserName = _userName;
                client.ClientCredentials.UserName.Password = _passWord;
                client.Inserir(item);
            }
        }

        public static void DeletarCategoria(CatServ.Categoria item)
        {
            WSHttpBinding binding = new WSHttpBinding();
            binding.Security.Mode = SecurityMode.Message;
            binding.Security.Message.ClientCredentialType =
                MessageCredentialType.UserName;
            binding.Security.Message.NegotiateServiceCredential = false;

            using (var client = new CatServ.CategoriaServiceClient())
            {
                if (client.ClientCredentials != null)
                    client.ClientCredentials
                        .ServiceCertificate
                        .SetDefaultCertificate(StoreLocation.LocalMachine,
                                               StoreName.My,
                                               X509FindType.FindBySubjectName,
                                               "CertificadoPD");

                client.ClientCredentials.UserName.UserName = _userName;
                client.ClientCredentials.UserName.Password = _passWord;
                client.Deletar(item);
            }
        }

        public static void AlterarCategoria(CatServ.Categoria item)
        {
            WSHttpBinding binding = new WSHttpBinding();
            binding.Security.Mode = SecurityMode.Message;
            binding.Security.Message.ClientCredentialType =
                MessageCredentialType.UserName;
            binding.Security.Message.NegotiateServiceCredential = false;

            using (var client = new CatServ.CategoriaServiceClient())
            {
                if (client.ClientCredentials != null)
                    client.ClientCredentials
                        .ServiceCertificate
                        .SetDefaultCertificate(StoreLocation.LocalMachine,
                                               StoreName.My,
                                               X509FindType.FindBySubjectName,
                                               "CertificadoPD");

                client.ClientCredentials.UserName.UserName = _userName;
                client.ClientCredentials.UserName.Password = _passWord;

                client.Alterar(item);
            }
        }

        #endregion

        #region Loja

        public static void InsertLoja(LojaServ.Loja item)
        {
            WSHttpBinding binding = new WSHttpBinding();
            binding.Security.Mode = SecurityMode.Message;
            binding.Security.Message.ClientCredentialType =
                MessageCredentialType.UserName;
            binding.Security.Message.NegotiateServiceCredential = false;

            using (var client = new LojaServ.LojaServiceClient())
            {
                if (client.ClientCredentials != null)
                    client.ClientCredentials
                        .ServiceCertificate
                        .SetDefaultCertificate(StoreLocation.LocalMachine,
                                               StoreName.My,
                                               X509FindType.FindBySubjectName,
                                               "CertificadoPD");

                client.ClientCredentials.UserName.UserName = _userName;
                client.ClientCredentials.UserName.Password = _passWord;
                client.Inserir(item);
            }
        }

        public static void DeletarLoja(LojaServ.Loja item)
        {
            WSHttpBinding binding = new WSHttpBinding();
            binding.Security.Mode = SecurityMode.Message;
            binding.Security.Message.ClientCredentialType =
                MessageCredentialType.UserName;
            binding.Security.Message.NegotiateServiceCredential = false;

            using (var client = new LojaServ.LojaServiceClient())
            {
                if (client.ClientCredentials != null)
                    client.ClientCredentials
                        .ServiceCertificate
                        .SetDefaultCertificate(StoreLocation.LocalMachine,
                                               StoreName.My,
                                               X509FindType.FindBySubjectName,
                                               "CertificadoPD");

                client.ClientCredentials.UserName.UserName = _userName;
                client.ClientCredentials.UserName.Password = _passWord;
                client.Deletar(item);
            }
        }

        public static void AlterarLoja(LojaServ.Loja item)
        {
            WSHttpBinding binding = new WSHttpBinding();
            binding.Security.Mode = SecurityMode.Message;
            binding.Security.Message.ClientCredentialType =
                MessageCredentialType.UserName;
            binding.Security.Message.NegotiateServiceCredential = false;

            using (var client = new LojaServ.LojaServiceClient())
            {
                if (client.ClientCredentials != null)
                    client.ClientCredentials
                        .ServiceCertificate
                        .SetDefaultCertificate(StoreLocation.LocalMachine,
                                               StoreName.My,
                                               X509FindType.FindBySubjectName,
                                               "CertificadoPD");

                client.ClientCredentials.UserName.UserName = _userName;
                client.ClientCredentials.UserName.Password = _passWord;
                client.Alterar(item);
            }
        }

        #endregion

        #region Marca

        public static void InsertMarca(MarcaServ.Marca item)
        {
            WSHttpBinding binding = new WSHttpBinding();
            binding.Security.Mode = SecurityMode.Message;
            binding.Security.Message.ClientCredentialType =
                MessageCredentialType.UserName;
            binding.Security.Message.NegotiateServiceCredential = false;

            using (var client = new MarcaServ.MarcaServiceClient())
            {
                if (client.ClientCredentials != null)
                    client.ClientCredentials
                        .ServiceCertificate
                        .SetDefaultCertificate(StoreLocation.LocalMachine,
                                               StoreName.My,
                                               X509FindType.FindBySubjectName,
                                               "CertificadoPD");

                client.ClientCredentials.UserName.UserName = _userName;
                client.ClientCredentials.UserName.Password = _passWord;
                client.Inserir(item);
            }
        }

        public static void DeletarMarca(MarcaServ.Marca item)
        {
            WSHttpBinding binding = new WSHttpBinding();
            binding.Security.Mode = SecurityMode.Message;
            binding.Security.Message.ClientCredentialType =
                MessageCredentialType.UserName;
            binding.Security.Message.NegotiateServiceCredential = false;

            using (var client = new MarcaServ.MarcaServiceClient())
            {
                if (client.ClientCredentials != null)
                    client.ClientCredentials
                        .ServiceCertificate
                        .SetDefaultCertificate(StoreLocation.LocalMachine,
                                               StoreName.My,
                                               X509FindType.FindBySubjectName,
                                               "CertificadoPD");

                client.ClientCredentials.UserName.UserName = _userName;
                client.ClientCredentials.UserName.Password = _passWord;
                client.Deletar(item);
            }
        }

        public static void AlterarMarca(MarcaServ.Marca item)
        {
            WSHttpBinding binding = new WSHttpBinding();
            binding.Security.Mode = SecurityMode.Message;
            binding.Security.Message.ClientCredentialType =
                MessageCredentialType.UserName;
            binding.Security.Message.NegotiateServiceCredential = false;

            using (var client = new MarcaServ.MarcaServiceClient())
            {
                if (client.ClientCredentials != null)
                    client.ClientCredentials
                        .ServiceCertificate
                        .SetDefaultCertificate(StoreLocation.LocalMachine,
                                               StoreName.My,
                                               X509FindType.FindBySubjectName,
                                               "CertificadoPD");

                client.ClientCredentials.UserName.UserName = _userName;
                client.ClientCredentials.UserName.Password = _passWord;
                client.Alterar(item);
            }
        }

        #endregion

        #region Modelo

        public static void InsertModelo(ModeloServ.Modelo item)
        {
            WSHttpBinding binding = new WSHttpBinding();
            binding.Security.Mode = SecurityMode.Message;
            binding.Security.Message.ClientCredentialType =
                MessageCredentialType.UserName;
            binding.Security.Message.NegotiateServiceCredential = false;

            using (var client = new ModeloServ.ModeloServiceClient())
            {
                if (client.ClientCredentials != null)
                    client.ClientCredentials
                        .ServiceCertificate
                        .SetDefaultCertificate(StoreLocation.LocalMachine,
                                               StoreName.My,
                                               X509FindType.FindBySubjectName,
                                               "CertificadoPD");

                client.ClientCredentials.UserName.UserName = _userName;
                client.ClientCredentials.UserName.Password = _passWord;
                client.Inserir(item);
            }
        }

        public static void DeletarModelo(ModeloServ.Modelo item)
        {
            WSHttpBinding binding = new WSHttpBinding();
            binding.Security.Mode = SecurityMode.Message;
            binding.Security.Message.ClientCredentialType =
                MessageCredentialType.UserName;
            binding.Security.Message.NegotiateServiceCredential = false;

            using (var client = new ModeloServ.ModeloServiceClient())
            {
                if (client.ClientCredentials != null)
                    client.ClientCredentials
                        .ServiceCertificate
                        .SetDefaultCertificate(StoreLocation.LocalMachine,
                                               StoreName.My,
                                               X509FindType.FindBySubjectName,
                                               "CertificadoPD");

                client.ClientCredentials.UserName.UserName = _userName;
                client.ClientCredentials.UserName.Password = _passWord;
                client.Deletar(item);
            }
        }

        public static void AlterarModelo(ModeloServ.Modelo item)
        {
            WSHttpBinding binding = new WSHttpBinding();
            binding.Security.Mode = SecurityMode.Message;
            binding.Security.Message.ClientCredentialType =
                MessageCredentialType.UserName;
            binding.Security.Message.NegotiateServiceCredential = false;

            using (var client = new ModeloServ.ModeloServiceClient())
            {
                if (client.ClientCredentials != null)
                    client.ClientCredentials
                        .ServiceCertificate
                        .SetDefaultCertificate(StoreLocation.LocalMachine,
                                               StoreName.My,
                                               X509FindType.FindBySubjectName,
                                               "CertificadoPD");

                client.ClientCredentials.UserName.UserName = _userName;
                client.ClientCredentials.UserName.Password = _passWord;
                client.Alterar(item);
            }
        }

        #endregion

        #region Produto

        public static void InsertProduto(ProdutoServ.Produto item)
        {
            WSHttpBinding binding = new WSHttpBinding();
            binding.Security.Mode = SecurityMode.Message;
            binding.Security.Message.ClientCredentialType =
                MessageCredentialType.UserName;
            binding.Security.Message.NegotiateServiceCredential = false;

            using (var client = new ProdutoServ.ProdutoServiceClient())
            {
                if (client.ClientCredentials != null)
                    client.ClientCredentials
                        .ServiceCertificate
                        .SetDefaultCertificate(StoreLocation.LocalMachine,
                                               StoreName.My,
                                               X509FindType.FindBySubjectName,
                                               "CertificadoPD");

                client.ClientCredentials.UserName.UserName = _userName;
                client.ClientCredentials.UserName.Password = _passWord;
                client.Inserir(item);
            }
        }

        public static void DeletarProduto(ProdutoServ.Produto item)
        {
            WSHttpBinding binding = new WSHttpBinding();
            binding.Security.Mode = SecurityMode.Message;
            binding.Security.Message.ClientCredentialType =
                MessageCredentialType.UserName;
            binding.Security.Message.NegotiateServiceCredential = false;

            using (var client = new ProdutoServ.ProdutoServiceClient())
            {
                if (client.ClientCredentials != null)
                    client.ClientCredentials
                        .ServiceCertificate
                        .SetDefaultCertificate(StoreLocation.LocalMachine,
                                               StoreName.My,
                                               X509FindType.FindBySubjectName,
                                               "CertificadoPD");

                client.ClientCredentials.UserName.UserName = _userName;
                client.ClientCredentials.UserName.Password = _passWord;
                client.Deletar(item);
            }
        }

        public static void AlterarProduto(ProdutoServ.Produto item)
        {
            WSHttpBinding binding = new WSHttpBinding();
            binding.Security.Mode = SecurityMode.Message;
            binding.Security.Message.ClientCredentialType =
                MessageCredentialType.UserName;
            binding.Security.Message.NegotiateServiceCredential = false;

            using (var client = new ProdutoServ.ProdutoServiceClient())
            {
                if (client.ClientCredentials != null)
                    client.ClientCredentials
                        .ServiceCertificate
                        .SetDefaultCertificate(StoreLocation.LocalMachine,
                                               StoreName.My,
                                               X509FindType.FindBySubjectName,
                                               "CertificadoPD");

                client.ClientCredentials.UserName.UserName = _userName;
                client.ClientCredentials.UserName.Password = _passWord;
                client.Alterar(item);
            }
        }

        #endregion

        private static String _userName { get; set; }
        private static String _passWord { get; set; }

        public static void SetLoginCredentials(string userName, string password)
        {
            _userName = userName;
            _passWord = password;
        }

        private static DataServ.PecaDicaBDEntities _contexto;

        public static DataServ.PecaDicaBDEntities Contexto
        {
            get
            {
                return _contexto ?? (_contexto = new DataServ
                                                     .PecaDicaBDEntities(
                                                     new Uri("http://localhost:63962/DataServices/ModelDataService.svc/")));
            }
        }

        //private static LojaServ.LojaServiceClient  _lojaCliente;
        //public static LojaServ.LojaServiceClient LojaCliente
        //{
        //    get { return _lojaCliente ?? (_lojaCliente = new LojaServ.LojaServiceClient()); }
        //}

        //private static ProdutoServ.ProdutoServiceClient _produtoCliente;
        //public static ProdutoServ.ProdutoServiceClient ProdutoCliente
        //{
        //    get { return _produtoCliente ?? (_produtoCliente = new ProdutoServ.ProdutoServiceClient()); }
        //}

        //private static ModeloServ.ModeloServiceClient _modeloCliente;
        //public static ModeloServ.ModeloServiceClient ModeloCliente
        //{
        //    get { return _modeloCliente ?? (_modeloCliente = new ModeloServ.ModeloServiceClient()); }
        //}

        //private static MarcaServ.MarcaServiceClient _marcaCliente;
        //public static MarcaServ.MarcaServiceClient MarcaCliente
        //{
        //    get { return _marcaCliente ?? (_marcaCliente = new MarcaServ.MarcaServiceClient()); }
        //}

        //private static CatServ.CategoriaServiceClient _categoriaCliente;
        //public static CatServ.CategoriaServiceClient CategoriaCliente
        //{
        //    get { return _categoriaCliente ?? (_categoriaCliente = new CatServ.CategoriaServiceClient()); }
        //}
    }
}