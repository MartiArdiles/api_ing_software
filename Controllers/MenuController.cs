using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.Extensions.Logging;
using Menues;

[ApiController]
[Route("[controller]")]
public class MenuController : ControllerBase
{
    private readonly ILogger<MenuController> _logger;

    public MenuController(ILogger<MenuController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetMenu")]
    public List<Menu> Get()
    {
        Bebida bebida = new Bebida();
        bebida.Nombre = "Coca";
        bebida.Cantidad = 1;
        bebida.Descripcion = "Coca con hielo";
        bebida.Precio = 150;
        Chori chori = new Chori();
        chori.EsVegano = 0;
        chori.Descripcion = "Chori Comun";
        chori.Precio = 1000;
        chori.Cantidad = 1;
        

        List<Menu> menus = new List<Menu>{};
        Menu menu = new Menu();
        menu.TieneExtra = true;
        menu.Descripcion = chori.Descripcion + " " + bebida.Descripcion + " : $" + (chori.Precio + bebida.Precio) + " " + (menu.TieneExtra ? "Con papas" : "");
        menu.Id = 1;       

        menus.Add(menu);

        return menus;
    }
}