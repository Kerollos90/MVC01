using Microsoft.AspNetCore.Mvc;

namespace MVC01.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello ";
        }
        
        public ActionResult AboutUs()
        {
            return Content("AboutUs ");
        }
        public ActionResult Url()
        {
            return Redirect("https://localhost:44364/home/aboutus");
        }
    }
}
