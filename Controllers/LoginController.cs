using JMA.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace JMA.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            // Cargar la lista de empresas
            var model = new LoginModel
            {
                Empresas = new List<Empresa>
                {
                    new Empresa { Id = 1, Nombre = "Empresa A" },
                    new Empresa { Id = 2, Nombre = "Empresa B" },
                    new Empresa { Id = 3, Nombre = "Empresa C" }
                }
            };

            return View(model); // Pasar el modelo con las empresas a la vista
        }

        [HttpPost]
        public IActionResult Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Usuario == "Francisco" && model.Clave == "jma123")
                {
                    HttpContext.Session.SetString("Usuario", model.Usuario);
                    return RedirectToAction("Index", "Home");
                }

                TempData["Error"] = "Usuario o contraseña incorrectos";
            }
            else
            {
                // Si la validación falla por no seleccionar empresa
                if (model.EmpresaId == 0)
                {
                    TempData["Error"] = "Debe seleccionar una empresa válida";
                }
            }

            // Si la validación falla, devolver el modelo con la lista de empresas
            model.Empresas = new List<Empresa>
            {
                new Empresa { Id = 1, Nombre = "Empresa A" },
                new Empresa { Id = 2, Nombre = "Empresa B" },
                new Empresa { Id = 3, Nombre = "Empresa C" }
            };

            return View(model);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");
        }
    }
}
