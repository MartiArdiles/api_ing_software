using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.Extensions.Logging;
using Menues;

//namespace api_ing_software.Controllers{}

[ApiController]
[Route("[controller]")]
public class BebidaController : ControllerBase
{
    private readonly ILogger<BebidaController> _logger;

    public BebidaController(ILogger<BebidaController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetBebida")]
    public Bebida Get()
    {
        Bebida bebida = new Bebida();
        //bebida.SumarizarBebida();

        return bebida; 
    }
}