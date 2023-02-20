using AgendaContatos.Presentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgendaContatos.Presentation.Controllers
{
    public class AccountController : Controller
    {
        /// <summary>
        /// Método para abrir a página /Account/Login
        /// </summary>
        public IActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// Método para receber o SUBMIT POST do formulário
        /// </summary>
        [HttpPost]
        public IActionResult Login(AccountLoginModel model)
        {
            return View();
        }

        /// <summary>
        /// Método para abrir a página /Account/Register
        /// </summary>
        public IActionResult Register()
        {
            return View();
        }

        /// <summary>
        /// Método para receber o SUBMIT POST do formulário
        /// </summary>
        [HttpPost]
        public IActionResult Register(AccountRegisterModel model)
        {
            return View();
        }
    }
}
