using System;
using Datos;
using Entity;
using System.Collections.Generic;
using System.Linq;
 
namespace Logica
{
    public class VacunacionsService
    {
        private readonly SeungoParcialWebContext _context;
        
 
        public VacunacionsService(SeungoParcialWebContext context)
        {
            _context = context;
        }
 
        public class GuardarVacunacionsResponse
        {
            public GuardarVacunacionsResponse(Vacunacions vacuna)
            {
                Error = false;
                Vacunacions = vacuna;
            }
 
            public GuardarVacunacionsResponse(string mensaje)
            {
                Error = true;
                Mensaje = mensaje;
            }
 
            public bool Error { get; set; }
            public string Mensaje { get; set; }
            public Vacunacions Vacunacions { get; set; }
        }
 
        public GuardarVacunacionsResponse Guardar(Vacunacions vacuna)
        {
            try
            {
                _context.vacunas.Add(vacuna);
                
                _context.SaveChanges();
                return new GuardarVacunacionsResponse(vacuna);
               
            }
            catch (Exception e)
            {
                return new GuardarVacunacionsResponse($"Error de la Aplicacion: {e.Message}");
            }
            
        }
 
        public List<Vacunacions> ConsultarTodos()
        {
            
            List<Vacunacions> vacuna = _context.vacunas.ToList();
           
            return vacuna;
        }
 
    }
}
