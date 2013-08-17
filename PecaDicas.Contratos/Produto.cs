using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using PecaDicas.Contratos.Common;

namespace PecaDicas.Contratos
{
    [DataContract]
    public class Produto: IDValuePair
    {       
        [DataMember]
        public virtual Guid CategoriaID { get; set; }
        [DataMember]
        public virtual Guid ModeloID { get; set; }
        [DataMember]
        public virtual Guid LojaID { get; set; }

    }
}
