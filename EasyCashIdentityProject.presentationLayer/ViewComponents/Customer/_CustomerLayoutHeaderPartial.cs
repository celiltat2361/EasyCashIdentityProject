using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.presentationLayer.ViewComponents.Customer
{
	public class _CustomerLayoutHeaderPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
