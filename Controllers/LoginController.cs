using JMA.Models;
using Microsoft.AspNetCore.Mvc;

namespace JMA.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Usuario == "Apple" && model.Clave == "jma123") // Simulación de login
                {
                    HttpContext.Session.SetString("Usuario", model.Usuario);  // Guardamos el usuario en la sesión
                    return RedirectToAction("Index", "Home");
                }

                TempData["Error"] = "Usuario o contraseña incorrectos"; // Mensaje de erro
            }
            return View(model);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();  // Borra la sesión
            return RedirectToAction("Index", "Login"); // Redirige al login
        }

    }
}