using System.ServiceModel;
using PecaDicas.Contratos.Common;

namespace PecaDicas.Contratos
{
    [ServiceContract]
    public interface ICategoriaService
    {
        [OperationContract]
        [FaultContract(typeof(DetalhamentoFalha))]
        void Inserir(Categoria item);

        [OperationContract]
        [FaultContract(typeof(DetalhamentoFalha))]
        void Deletar(Categoria item);

        [OperationContract]
        [FaultContract(typeof(DetalhamentoFalha))]
        void Alterar(Categoria item);

    }
}
