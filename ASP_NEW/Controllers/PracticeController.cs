using Microsoft.AspNetCore.Mvc;

namespace ASP_NEW.Controllers
{
    public class PracticeController : Controller
    {
        public ViewResult MyMethod()
        { 
           return View("Test3");
        }
    }
}
