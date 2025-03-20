using JMA.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace JMA.Controllers
{
    public class PacienteController : Controller
    {
        private static List<Paciente> pacientes = new List<Paciente>(); // Simulación de base de datos

        // Acción GET: Mostrar formulario de nuevo paciente
        public IActionResult Crear()
        {
            return View();
        }

        // Acción POST: Procesar formulario y guardar el paciente
        [HttpPost]
        public IActionResult Crear(Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                // Simulación de guardar el paciente
                pacientes.Add(paciente);

                // Redirigir a otra vista, en este caso, Home/Index
                return RedirectToAction("Index", "Home");
            }

            // Si el formulario no es válido, se muestra el formulario de nuevo
            return View(paciente);
        }
    }
}
