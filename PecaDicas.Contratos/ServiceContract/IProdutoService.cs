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
        void Inserir(PecaDica.Modelo.Produto item);

        [OperationContract]
        [FaultContract(typeof(DetalhamentoFalha))]
        void Deletar(PecaDica.Modelo.Produto item);

        [OperationContract]
        [FaultContract(typeof(DetalhamentoFalha))]
        void Alterar(PecaDica.Modelo.Produto item);
    }
}
