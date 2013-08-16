using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;


namespace PecaDicas.Contratos.Common
{
    [ServiceContract]
    public interface IServicoBanco<T> where T:IDValuePair
    {
        [OperationContract]
        [FaultContract(typeof(DetalhamentoFalha))]
        void Inserir(T item);

        [OperationContract]
        [FaultContract(typeof(DetalhamentoFalha))]
        void Deletar(T item);

        [OperationContract]
        [FaultContract(typeof(DetalhamentoFalha))]
        void Alterar(T item);

        //[OperationContract]
        //T[] ConsultarTodos();
        //[OperationContract]
        //T ConsultarPorId(Guid ID);
    }
}
