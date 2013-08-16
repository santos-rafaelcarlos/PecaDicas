using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using PecaDicas.Contratos;
using PecaDicas.Contratos.Common;
using System.Security.Permissions;

namespace PecaDicas.Services
{    
    public class CategoriaService : ICategoriaService
    {
        [PrincipalPermission(SecurityAction.Demand, Role="loja")]
        public void Inserir(Categoria item)
        {
            throw new NotImplementedException();
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "loja")]
        public void Deletar(Categoria item)
        {
            throw new NotImplementedException();
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "loja")]
        public void Alterar(Categoria item)
        {
            throw new NotImplementedException();
        }
    }
}
