﻿using System;
using Datos;
using Entity;
using System.Collections.Generic;
using System.Linq;
 
namespace Logica
{
    public class PersonaService
    {
        private readonly SeungoParcialWebContext _context;
        
 
        public PersonaService(SeungoParcialWebContext context)
        {
            _context = context;
        }
 
        public class GuardarPersonaResponse
        {
            public GuardarPersonaResponse(Persona persona)
            {
                Error = false;
                Persona = persona;
            }
 
            public GuardarPersonaResponse(string mensaje)
            {
                Error = true;
                Mensaje = mensaje;
            }
 
            public bool Error { get; set; }
            public string Mensaje { get; set; }
            public Persona Persona { get; set; }
        }
 
        public GuardarPersonaResponse Guardar(Persona persona)
        {
            try
            {
                _context.personas.Add(persona);
                
                _context.SaveChanges();
                return new GuardarPersonaResponse(persona);
               
            }
            catch (Exception e)
            {
                return new GuardarPersonaResponse($"Error de la Aplicacion: {e.Message}");
            }
            
        }
 
        public List<Persona> ConsultarTodos()
        {
            
            List<Persona> personas = _context.personas.ToList();
           
            return personas;
        }
 
    }
}
