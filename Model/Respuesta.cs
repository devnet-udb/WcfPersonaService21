using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfPersonaService21.Model
{
    [DataContract]
    public class Respuesta
    {
        public string MensajeRespuesta { get; set; }
        [DataMember]
        public string Error { get; set; }
    }
}