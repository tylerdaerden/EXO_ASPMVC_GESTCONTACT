using Microsoft.AspNetCore.Mvc;

namespace FQ23L034_DemoAsp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
        public IActionResult Contact()
        {
            return View("Contact");
        }
    }
}
