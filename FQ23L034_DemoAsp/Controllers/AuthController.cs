using Microsoft.AspNetCore.Mvc;

namespace FQ23L034_DemoAsp.Controllers
{
    public class AuthController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Register()
        {
            return View("Register");
        }

        public IActionResult Login()
        {
            return RedirectToAction("Login");
        }
    }
}
