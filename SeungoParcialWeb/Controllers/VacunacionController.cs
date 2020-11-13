using System;
using System.Collections.Generic;
using System.Linq;
using Logica;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SeungoParcialWeb.Models;
using Datos;
 
namespace SeungoParcialWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VacunacionController : ControllerBase
    {
        private readonly VacunacionsService _vacunaService;
        public IConfiguration Configuration { get; }
        public VacunacionController(SeungoParcialWebContext context)
        {
            
            _vacunaService = new VacunacionsService(context);
        }
    private Vacunacions MapearVacunacion(VacunacionInputModel vacunaInput)
        {
            var vacuna = new Vacunacions
            {
                TipoDocumento = vacunaInput.TipoDocumento,
                Identificacion = vacunaInput.Identificacion,
                Nombre = vacunaInput.Nombre,
                FechaNacimiento = vacunaInput.FechaNacimiento,
                NombreInstitucion = vacunaInput.NombreInstitucion,
                NombreAcudiente = vacunaInput.NombreAcudiente,
                TipoVacuna = vacunaInput.TipoVacuna,
                FechaVacuna = vacunaInput.FechaVacuna,
                EdadPersonaAplicacion = vacunaInput.EdadPersonaAplicacion

            };
            return vacuna;
        }
 
       [HttpGet]
        public IEnumerable<VacunacionViewModel> Gets()
        {
            var vacuna = _vacunaService.ConsultarTodos().Select(p=> new VacunacionViewModel(p));
            return vacuna;
        }
 
        [HttpPost]
        public ActionResult<VacunacionViewModel> Post(VacunacionInputModel vacunaInput)
        {
            Vacunacions vacuna = MapearVacunacion(vacunaInput);
            var response = _vacunaService.Guardar(vacuna);
            if (response.Error) 
            {
                return BadRequest(response.Mensaje);
            }
            return Ok(response.Vacunacions);
        }
 
        
 
        
    }
}
