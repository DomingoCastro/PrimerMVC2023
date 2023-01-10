using Microsoft.AspNetCore.Mvc;
using PrimerMVC2023.Models;

namespace PrimerMVC2023.Controllers
{
    public class InformacionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ControllerView()
        {
            //Aqui enviamos la informacion simple
            ViewBag.Nombre = "Alumno";
            ViewData["Descripcion"] = "Estoy aprendiendo Net Core MVC";
            ViewData["Year"] = 2023;

            return View();
        }
        public IActionResult ControllerViewModel()
        {
            // Creamos un objeto persona para enviarlo
            Persona persona = new Persona();
            persona.Nombre = "Alumno Net Core";
            persona.Edad = 40;
            persona.Email = "Alumnonet@gmail.com";
            persona.Imagen = "https://cdn-icons-png.flaticon.com/512/57/57117.png";
            // Enviamos el modelo a la vista
            return View(persona);
        }
        public IActionResult ControllerViewModelList()
        {
            //VAMOS A REALIZAR UN BUCLE PARA CREARNOS MULTIPLES PERSONAS
            List<Persona> personas = new List<Persona>();
            for (int i = 1; i <= 10; i++)
            {
                Persona persona = new Persona();
                persona.Nombre = "Persona " + i;
                persona.Edad = i + 20;
                persona.Email = "Persona" + i + "@gmail.com";
                persona.Imagen = "https://cdn-icons-png.flaticon.com/512/57/57117.png";
                personas.Add(persona);

            }
            return View(personas);
        }
    }
}
