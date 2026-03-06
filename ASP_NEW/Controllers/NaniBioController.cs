using Microsoft.AspNetCore.Mvc;

using ASP_NEW.Model;
using Microsoft.AspNetCore.Mvc.TagHelpers;



namespace ASP_NEW.Controllers
{
    public class NaniBioController : Controller
    {
        public IActionResult RegistraionAKHILA()
        {
            return View();
        }

        public IActionResult StudentRegistration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult registration(reg data)
        {

            return View(data);
        }
    }
}
