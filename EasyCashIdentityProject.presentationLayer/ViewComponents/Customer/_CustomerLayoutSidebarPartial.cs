using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.presentationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutSidebarPartial : ViewComponent 
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
