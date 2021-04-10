using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfPersonaService21.Model;

namespace WcfPersonaService21
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IWSPersonas" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWSPersonas
    {
        [OperationContract]
        Persona obtenerPersona(string identificador);
    }
}
