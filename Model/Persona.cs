using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfPersonaService21.Model
{
    [DataContract]
    public class Persona:Respuesta
    {
        [DataMember]
        public string Nombres { get; set; }
        [DataMember]
        public string Apellidos { get; set; }
        [DataMember]
        public int Edad { get; set; }
        public string Dui { get; set; }
        public Persona()
        {

        }

        public Persona(string nombres, string apellidos, int edad, string dui)
        {
            Nombres = nombres;
            Apellidos = apellidos;
            Edad = edad;
            Dui = dui;
        }
    }
}