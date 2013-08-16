using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PecaDicas.Contratos.Common;
using System.ServiceModel;

namespace PecaDicas.Contratos
{
    [ServiceContract]
    public interface IProdutoService:IServicoBanco<Produto>
    {
    }
}
