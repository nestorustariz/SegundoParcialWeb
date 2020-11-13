using System;
using System.ComponentModel.DataAnnotations;
 
namespace Entity
{
    public class Vacunacions
    {
        public string TipoDocumento { get; set;}

        [Key]
        public string Identificacion { get; set; }

        public string Nombre { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string NombreInstitucion { get; set; }
        
        public string NombreAcudiente { get; set; }

        public string TipoVacuna { get; set; }

        public DateTime FechaVacuna { get; set; }

        public int EdadPersonaAplicacion { get; set; }

        public void CalcularEdadAplicacion(){

            EdadPersonaAplicacion = FechaNacimiento.Year - FechaVacuna.Year;

        }

    }
}