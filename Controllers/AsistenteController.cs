﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.Extensions.Logging;
using Asistentes;
using Personas;

[ApiController]
[Route("[controller]")]
public class AsistenteController : ControllerBase
{
    private readonly ILogger<AsistenteController> _logger;

    public AsistenteController(ILogger<AsistenteController> logger)
    {
        _logger = logger;
    }


    [HttpGet(Name = "GetAsistente")]
    public Asistente Get()
    {
        Persona persona = new Persona();
        persona.IDPersona = 1;
        persona.Email = "marti.ardiles@gmail.com";
        persona.Nombre = "Martina";
        persona.Apellido = "Ardiles";

        Asistente asistente = new Asistente(); 
                                        
        asistente.IDAsistente = 1;
        asistente.Asistio = true;
        asistente.IDChorifest = 1;
        asistente.Pagado = true;
        asistente.Descripcion = persona.Nombre + " " + persona.Apellido + " - " + (asistente.Pagado ? "Pagado" : "No pagado");
        
        return asistente; 
    }
}