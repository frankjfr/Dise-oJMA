using JMA.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace JMA.Controllers
{
    public class PacienteController : Controller
    {
        private static List<Paciente> pacientes = new List<Paciente>(); // Simulaci�n de base de datos

        // Acci�n GET: Mostrar formulario de nuevo paciente
        public IActionResult Crear()
        {
            return View();
        }

        // Acci�n POST: Procesar formulario y guardar el paciente
        [HttpPost]
        public IActionResult Crear(Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                // Simulaci�n de guardar el paciente
                pacientes.Add(paciente);

                // Redirigir a otra vista, en este caso, Home/Index
                return RedirectToAction("Index", "Home");
            }

            // Si el formulario no es v�lido, se muestra el formulario de nuevo
            return View(paciente);
        }
    }
}
