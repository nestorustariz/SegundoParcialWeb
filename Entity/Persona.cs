using System;
using System.ComponentModel.DataAnnotations;
 
namespace Entity
{
    public class Persona
    {
        public string TipoDocumento { get; set;}

        [Key]
        public string Identificacion { get; set; }

        public string Nombre { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string NombreInstitucion { get; set; }
        
        public string NombreAcudiente { get; set; }
    }
}
