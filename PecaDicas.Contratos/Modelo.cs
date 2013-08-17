using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using PecaDicas.Contratos.Common;

namespace PecaDicas.Contratos
{
    [DataContract]
    public class Modelo:IDValuePair
    {       
        [DataMember]
        public virtual Int32 Ano { get; set; }
        [DataMember]
        public virtual Guid MarcaID { get; set; }
    }
}
