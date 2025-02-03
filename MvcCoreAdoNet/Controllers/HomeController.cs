using Microsoft.AspNetCore.Mvc;
using MvcCoreAdoNet.Models;

namespace MvcCoreAdoNet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EjemploSection()
        {
            return View();
        }

        public IActionResult VistaPersona()
        {
            Persona p = new Persona();
            p.Nombre = "Alumno Core";
            p.Email = "alumnocore@gmail.com";
            p.Edad = 25;
            return View(p);
        }
    }
}
