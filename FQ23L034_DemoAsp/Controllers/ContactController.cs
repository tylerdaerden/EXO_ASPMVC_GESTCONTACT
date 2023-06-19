using Microsoft.AspNetCore.Mvc;

namespace FQ23L034_DemoAsp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult ContactList()
        {
            return ContactList();
        }
    }
}
