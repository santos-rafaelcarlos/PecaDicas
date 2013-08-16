using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PecaDicas.Contratos.Common
{    
    [DataContract]
    public class DetalhamentoFalha
    {
        [DataMember]
        public string Mensagem { get; set; }
        [DataMember]
        public string MensagemInterna { get; set; }
    } 
}
