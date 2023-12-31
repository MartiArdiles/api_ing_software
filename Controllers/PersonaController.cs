using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.Extensions.Logging;
using Menues;
using Personas;

//namespace api_ing_software.Controllers{}

[ApiController]
[Route("[controller]")]
public class PersonaController : ControllerBase
{
    private readonly ILogger<PersonaController> _logger;

    public PersonaController(ILogger<PersonaController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetPersona")]
    public Persona Get()
    {        
        Persona persona = new Persona(); 
                                         
        persona.IDPersona = 1;
        persona.Email = "marti.ardiles@gmail.com";
        persona.Nombre = "Martina";
        persona.Apellido = "Ardiles";

        return persona;
    }
}