using System.ServiceModel;
using PecaDicas.Contratos.Common;

namespace PecaDicas.Contratos
{
    [ServiceContract]
    public interface IMarcaService
    {
        [OperationContract]
        [FaultContract(typeof(DetalhamentoFalha))]
        void Inserir(PecaDica.Modelo.Marca item);

        [OperationContract]
        [FaultContract(typeof(DetalhamentoFalha))]
        void Deletar(PecaDica.Modelo.Marca item);

        [OperationContract]
        [FaultContract(typeof(DetalhamentoFalha))]
        void Alterar(PecaDica.Modelo.Marca item);

    }
}
