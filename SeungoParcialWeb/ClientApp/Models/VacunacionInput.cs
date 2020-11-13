using Entity;
using System;
namespace SeungoParcialWeb.Models
{
    public class VacunacionInputModel
    {
        public string TipoDocumento { get; set;}
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string NombreInstitucion { get; set; }
        public string NombreAcudiente { get; set; }
        public string TipoVacuna { get; set; }

        public DateTime FechaVacuna { get; set; }

        public int EdadPersonaAplicacion { get; set; }
    
    }
 
    public class VacunacionViewModel : VacunacionInputModel
    {
        public VacunacionViewModel()
        {
 
        }
        public VacunacionViewModel(Vacunacions vacuna)
        {
            TipoDocumento = vacuna.TipoDocumento;
            Identificacion = vacuna.Identificacion;
            Nombre = vacuna.Nombre;
            FechaNacimiento = vacuna.FechaNacimiento;
            NombreInstitucion = vacuna.NombreInstitucion;
            NombreAcudiente = vacuna.NombreAcudiente;
            TipoVacuna = vacuna.TipoVacuna;
            FechaVacuna = vacuna.FechaVacuna;
            EdadPersonaAplicacion = vacuna.EdadPersonaAplicacion;
        }
    }
}
