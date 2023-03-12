using Microsoft.AspNetCore.Mvc;

namespace asp.netCore.Controllers
{
    public class DefaultConturoler : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeaderPartial()
        {
            return PartialView(); 
        }
        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }
    }
}
