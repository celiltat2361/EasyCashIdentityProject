using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.presentationLayer.Controllers
{
    public class MyProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
