using EasyCashIdentityProject.EntityLayer.Concrete;
using EasyCashIdentityProject.presentationLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.presentationLayer.Controllers
{
    public class ComfirmMailController : Controller
    {
            
        private readonly UserManager<AppUser> _userManager;
        public ComfirmMailController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            var value = TempData["Mail"];
            ViewBag.v = value;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(ComfirmMailViewModel comfirmMailViewModel)
        {
          
            var user = await _userManager.FindByEmailAsync(comfirmMailViewModel.Mail);
            if (user.ComfirmCode == comfirmMailViewModel.ComfirmCode)
            {
                user.EmailConfirmed = true;
                await _userManager.UpdateAsync(user);
                return RedirectToAction("Index", "Login");
            }
            return View();
        }

    }
}
