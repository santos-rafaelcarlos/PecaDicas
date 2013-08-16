using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using PecaDicas.Contratos.Common;

namespace PecaDicas.Contratos
{
    [DataContract]
    public class Loja : IDValuePair
    {
        [DataMember]
        public virtual String NomeUsuario { get; set; }
        
        [DataMember]
        public virtual String Senha { get; set; }

        [DataMember]
        public virtual String Email { get; set; }

        [DataMember]
        public virtual String Endereco { get; set; }
    }
}
