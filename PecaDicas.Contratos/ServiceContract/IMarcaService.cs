using System.ServiceModel;
using PecaDicas.Contratos.Common;

namespace PecaDicas.Contratos
{
    [ServiceContract]
    public interface IMarcaService
    {
        [OperationContract]
        [FaultContract(typeof(DetalhamentoFalha))]
        void Inserir(Marca item);

        [OperationContract]
        [FaultContract(typeof(DetalhamentoFalha))]
        void Deletar(Marca item);

        [OperationContract]
        [FaultContract(typeof(DetalhamentoFalha))]
        void Alterar(Marca item);

    }
}
