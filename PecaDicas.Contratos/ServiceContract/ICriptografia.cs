using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace PecaDicas.Contratos.Common
{
    [ServiceContract]
    public interface ICriptografia
    {
        [OperationContract]
        [FaultContract(typeof(DetalhamentoFalha))]
        string Criptografar(string text);
        [OperationContract]
        [FaultContract(typeof(DetalhamentoFalha))]
        string Descriptografar(string text);
    }
}
