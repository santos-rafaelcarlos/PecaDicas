using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PecaDicas.Contratos.Common;

namespace PecaDicas.Contratos
{
    [ServiceContract]
    public interface ILojaService
    {
        [OperationContract]
        [FaultContract(typeof(DetalhamentoFalha))]
        void Inserir(Loja item);

        [OperationContract]
        [FaultContract(typeof(DetalhamentoFalha))]
        void Deletar(Loja item);

        [OperationContract]
        [FaultContract(typeof(DetalhamentoFalha))]
        void Alterar(Loja item);
    }
}
