using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ManejoDeArchivoWeb.Models;
using System.Xml.Serialization;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ManejoDeArchivoWeb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpPost]
    public ActionResult CargaXML(IFormFile cargarArchivo, string tipo)
    {
       
            string jsonString = "";
            var name = Path.GetExtension(cargarArchivo.FileName).Split(".");
            if (name[1] == "xml" && tipo == "c")
            {
                var xmlSerializer = new XmlSerializer(typeof(PedidoCompra));
                using (var reader = new StreamReader(cargarArchivo.OpenReadStream()))
                {
                    var member = (PedidoCompra)xmlSerializer.Deserialize(reader);

                     jsonString = JsonSerializer.Serialize(member);
                    ViewBag.json = jsonString;
                    Console.WriteLine(jsonString);

                    

                }
            }
            else if (name[1] == "xml" && tipo == "v")
            {
                var xmlSerializer = new XmlSerializer(typeof(PedidoVenta));
                using (var reader = new StreamReader(cargarArchivo.OpenReadStream()))
                {
                    var member = (PedidoVenta)xmlSerializer.Deserialize(reader);

                     jsonString = JsonSerializer.Serialize(member);
                    ViewBag.json = jsonString;
                    Console.WriteLine(jsonString);
                    

                }
            }
            return Json(jsonString);
        

        
    }
}

