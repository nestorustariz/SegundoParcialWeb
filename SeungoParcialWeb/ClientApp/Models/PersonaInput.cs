using Entity;
using System;
namespace SeungoParcialWeb.Models
{
    public class PersonaInputModel
    {
        public string TipoDocumento { get; set;}
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string NombreInstitucion { get; set; }
        public string NombreAcudiente { get; set; }
    
    }
 
    public class PersonaViewModel : PersonaInputModel
    {
        public PersonaViewModel()
        {
 
        }
        public PersonaViewModel(Persona persona)
        {
            TipoDocumento = persona.TipoDocumento;
            Identificacion = persona.Identificacion;
            Nombre = persona.Nombre;
            FechaNacimiento = persona.FechaNacimiento;
            NombreInstitucion = persona.NombreInstitucion;
            NombreAcudiente = persona.NombreAcudiente;
        }
    }
}
