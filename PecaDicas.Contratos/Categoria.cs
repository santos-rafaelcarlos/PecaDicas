using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using PecaDicas.Contratos.Common;

namespace PecaDicas.Contratos
{
    [DataContract]
    public class Categoria:IDValuePair
    {
        [DataMember]
        public virtual String Descricao { get; set; }
    }
}
