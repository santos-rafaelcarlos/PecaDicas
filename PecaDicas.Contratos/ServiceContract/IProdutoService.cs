using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PecaDicas.Contratos.Common;

namespace PecaDicas.Contratos
{
    [ServiceContract]
    public interface IProdutoService
    {
        [OperationContract]
        [FaultContract(typeof(DetalhamentoFalha))]
        void Inserir(Produto item);

        [OperationContract]
        [FaultContract(typeof(DetalhamentoFalha))]
        void Deletar(Produto item);

        [OperationContract]
        [FaultContract(typeof(DetalhamentoFalha))]
        void Alterar(Produto item);
    }
}
