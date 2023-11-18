using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.Extensions.Logging;

//namespace api_ing_software.Controllers{}


[ApiController]
[Route("[controller]")]
public class ClienteController : ControllerBase
{
    private readonly ILogger<ClienteController> _logger;

    public ClienteController(ILogger<ClienteController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetCliente")]
    public Cliente Get()
    {
       Cliente cliente = new Cliente(); //instancia, devuelve un obj que se guarda en
                                        //la variable cliente 
        cliente.Name = "Martina";
        cliente.SurName = "Ardiles";
        cliente.Email = "marti.ardiles@gmail.com";
        cliente.DocumentNumber = 39454241;
        cliente.DocumentType = "DNI";

        return cliente; 
    }
}


