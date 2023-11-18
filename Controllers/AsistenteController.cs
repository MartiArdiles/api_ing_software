using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.Extensions.Logging;
using Entidades;

//namespace api_ing_software.Controllers{}

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
        Asistente asistente = new Asistente(); //instancia, devuelve un obj que se guarda en
                                        //la variable cliente 
        asistente.IDAsistente = 1;
        asistente.Asistio = true;
        asistente.IDChorifest = 1;
        asistente.Pagado = true;
        
        return asistente; 
    }
}