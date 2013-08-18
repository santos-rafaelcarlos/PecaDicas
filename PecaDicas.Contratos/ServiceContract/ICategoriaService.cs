using System.ServiceModel;
using PecaDicas.Contratos.Common;

namespace PecaDicas.Contratos
{
    [ServiceContract]
    public interface ICategoriaService
    {
        [OperationContract]
        [FaultContract(typeof(DetalhamentoFalha))]
        void Inserir(PecaDica.Modelo.Categoria item);

        [OperationContract]
        [FaultContract(typeof(DetalhamentoFalha))]
        void Deletar(PecaDica.Modelo.Categoria item);

        [OperationContract]
        [FaultContract(typeof(DetalhamentoFalha))]
        void Alterar(PecaDica.Modelo.Categoria item);

    }
}
