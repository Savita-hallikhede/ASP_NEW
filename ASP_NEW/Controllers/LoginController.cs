using Microsoft.AspNetCore.Mvc;

namespace ASP_NEW.Controllers
{
    public class LoginController :Controller
    {
        //[Route("HI")]
        public IActionResult UserLogin()
        { 
          return View();
        }

        public IActionResult UserLogin1()
        {
            return View();
        }
    }

}
