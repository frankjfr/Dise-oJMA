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
                if (model.EmpresaId == 0)
                {
                    TempData["Error"] = "Debe seleccionar una empresa válida";
                }
            }

            // Recargar la lista de empresas si hay error
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

        // Acción para cargar la vista parcial de recuperación de contraseña
        public IActionResult ForgotPasswordPartial()
        {
            return PartialView("_ForgotPasswordPartial", new ForgotPasswordModel());
        }

        // Acción para procesar la recuperación de contraseña
        [HttpPost]
        public IActionResult ForgotPassword(ForgotPasswordModel model)
        {
            if (ModelState.IsValid)
            {
                // Simulación de envío de correo con instrucciones (luego se implementa correctamente)
                TempData["SuccessMessage"] = "Se han enviado las instrucciones a su correo.";
                return PartialView("_ForgotPasswordPartial", new ForgotPasswordModel()); // Limpiar el formulario
            }

            return PartialView("_ForgotPasswordPartial", model); // Volver a mostrar la vista con errores
        }
    }
}
