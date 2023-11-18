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
public class ChoriController : ControllerBase
{
    private readonly ILogger<ChoriController> _logger;

    public ChoriController(ILogger<ChoriController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetChori")]
    public Chori Get()
    {
        Chori chori = new Chori();
        chori.SumarizarChori();

        return chori; 
    }
}