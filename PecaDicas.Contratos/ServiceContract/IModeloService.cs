using System.ServiceModel;
using PecaDicas.Contratos.Common;

namespace PecaDicas.Contratos
{
    [ServiceContract]
    public interface IModeloService
    {
        [OperationContract]
        [FaultContract(typeof(DetalhamentoFalha))]
        void Inserir(Modelo item);

        [OperationContract]
        [FaultContract(typeof(DetalhamentoFalha))]
        void Deletar(Modelo item);

        [OperationContract]
        [FaultContract(typeof(DetalhamentoFalha))]
        void Alterar(Modelo item);

    }
}
