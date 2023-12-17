using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.presentationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutNavbarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
