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
        void Inserir(PecaDica.Modelo.Loja item);

        [OperationContract]
        [FaultContract(typeof(DetalhamentoFalha))]
        void Deletar(PecaDica.Modelo.Loja item);

        [OperationContract]
        [FaultContract(typeof(DetalhamentoFalha))]
        void Alterar(PecaDica.Modelo.Loja item);
    }
}
