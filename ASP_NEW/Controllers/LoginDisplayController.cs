using Microsoft.AspNetCore.Mvc;
using ASP_NEW.Model;
using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace ASP_NEW.Controllers
{
    public class LoginDisplayController : Controller
    {

        [HttpPost]
        public IActionResult Display(User Data)
        {
            //ViewBag.FirstName = Firstname;
            //ViewBag.LastName = Lastname;

            //ViewData["FirstnameValue"] = Firstname;
            //ViewData["LastnameValue"] = Lastname;

            //List<string> list = new List<string>();
            // list.Add(Lastname);
            // list.Add(Firstname);


            //return View(list);

            //User obj = new User();
            //obj.Firstname = Firstname;
            //obj.Lastname = Lastname;

           // return View(obj);

            return View(Data);
        }
    }
}
