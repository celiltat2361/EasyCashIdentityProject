using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.presentationLayer.Controllers
{
    public class AccountListForCopyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
