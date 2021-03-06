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
    public class PersonaController : ControllerBase
    {
        private readonly PersonaService _personaService;
        public IConfiguration Configuration { get; }
        public PersonaController(SeungoParcialWebContext context)
        {
            
            _personaService = new PersonaService(context);
        }
    private Persona MapearPersona(PersonaInputModel personaInput)
        {
            var persona = new Persona
            {
                TipoDocumento = personaInput.TipoDocumento,
                Identificacion = personaInput.Identificacion,
                Nombre = personaInput.Nombre,
                FechaNacimiento = personaInput.FechaNacimiento,
                NombreInstitucion = personaInput.NombreInstitucion,
                NombreAcudiente = personaInput.NombreAcudiente
            };
            return persona;
        }
 
       [HttpGet]
        public IEnumerable<PersonaViewModel> Gets()
        {
            var personas = _personaService.ConsultarTodos().Select(p=> new PersonaViewModel(p));
            return personas;
        }
 
        [HttpPost]
        public ActionResult<PersonaViewModel> Post(PersonaInputModel personaInput)
        {
            Persona persona = MapearPersona(personaInput);
            var response = _personaService.Guardar(persona);
            if (response.Error) 
            {
                return BadRequest(response.Mensaje);
            }
            return Ok(response.Persona);
        }
 
        
        [HttpGet("{identificacion}")]
        public Persona Get(string identificacion)
        {
            var persona = _personaService.BuscarxIdentificacion(identificacion);
            return persona;
        }
        
    }
}
