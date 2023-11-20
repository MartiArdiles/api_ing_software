﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.Extensions.Logging;
using Asistentes;
using Personas;
using dto.request;
using dto.response;
using Chorifests;

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
    public List<AsistenteResponseDTO> Get([FromQuery] AsistenteRequestDTO asistenteRequestDTO)
    {
        Persona persona = new Persona();

        List<Asistente> asistentes = new List<Asistente>{};
        Asistente asistente = new Asistente();                                
        asistente.IDAsistente = 1;
        asistente.Asistio = true;
        asistente.IDChorifest = 1;
        asistente.Pagado = true;
        asistente.Nombre = "Martina";
        asistente.Apellido = "Ardiles";
        asistente.Descripcion = asistente.NombreCompleto + " - " + (asistente.Pagado ? "Pagado" : "No pagado");
        asistente.IDChorifest = 1;

        asistentes.Add(asistente);

        List<Asistente> listaFiltrada = asistentes.Where(x => x.Nombre == asistenteRequestDTO.Nombre && x.Apellido == asistenteRequestDTO.Apellido).ToList();

        List<AsistenteResponseDTO> retorno = new List<AsistenteResponseDTO>();

        foreach(Asistente asistente1 in listaFiltrada)
        {
            retorno.Add(new AsistenteResponseDTO{Descripcion = asistente.Descripcion,
            IDChorifest = asistente.IDChorifest,
            IDAsistente = asistente.IDAsistente,
            Pagado = asistente.Pagado,
            Asistio = asistente.Asistio,
            });
        }

        return retorno;
    }
}