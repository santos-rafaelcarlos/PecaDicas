using System.ServiceModel;
using PecaDicas.Contratos.Common;

namespace PecaDicas.Contratos
{
    [ServiceContract]
    public interface IModeloService
    {
        [OperationContract]
        [FaultContract(typeof(DetalhamentoFalha))]
        void Inserir(PecaDica.Modelo.Modelo item);

        [OperationContract]
        [FaultContract(typeof(DetalhamentoFalha))]
        void Deletar(PecaDica.Modelo.Modelo item);

        [OperationContract]
        [FaultContract(typeof(DetalhamentoFalha))]
        void Alterar(PecaDica.Modelo.Modelo item);

    }
}
