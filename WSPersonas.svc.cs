using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfPersonaService21.Model;

namespace WcfPersonaService21
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "WSPersonas" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione WSPersonas.svc o WSPersonas.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WSPersonas : IWSPersonas
    {
        public Persona obtenerPersona(string identificador)
        {
            if (identificador.Equals("ana".ToLower()))
            {
                return new Persona()
                {
                    Nombres = "ana",
                    Apellidos = "lopez"
                };
                
            }else if (identificador.Equals("jose".ToLower()))
            {
                return new Persona()
                {
                    Nombres = "jose",
                    Apellidos = "perez"
                };
            }
            else
            {
                return new Persona()
                {
                    Error = "Persona no encontrada"
                };
            }
            
        }
    }
}
