using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PecaDicas.Contratos.Common
{
    [DataContract]
    public class IDValuePair
    {
        [DataMember]
        public virtual Guid ID { get; set; }
        [DataMember]
        public virtual string Nome { get; set; }
    }
}
