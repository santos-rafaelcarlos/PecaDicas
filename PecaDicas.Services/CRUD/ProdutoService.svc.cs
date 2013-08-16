using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PecaDicas.Contratos;
using PecaDicas.Contratos.Common;
using System.Security.Permissions;

namespace PecaDicas.Services
{    
    public class ProdutoService : IProdutoService
    {
        [PrincipalPermission(SecurityAction.Demand, Role = "loja")]
        public void Inserir(Produto item)
        {
            throw new NotImplementedException();
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "loja")]
        public void Deletar(Produto item)
        {            
            throw new NotImplementedException();
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "loja")]
        public void Alterar(Produto item)
        {
            throw new NotImplementedException();
        }
    }
}
