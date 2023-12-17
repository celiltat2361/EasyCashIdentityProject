using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.presentationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutScriptPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
