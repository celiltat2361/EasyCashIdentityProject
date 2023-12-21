using EasyCashIdentityProject.BusinessLayer.Abstract;
using EasyCashIdentityProject.DataAccessLayer.Concrete;
using EasyCashIdentityProject.DtoLayer.Dtos.CustomerAccountsProcessDtos;
using EasyCashIdentityProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.presentationLayer.Controllers
{
    public class SendMoneyController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ICustomerAccountProcessService _customerAccountProcessService;

        public SendMoneyController(UserManager<AppUser> userManager, ICustomerAccountProcessService customerAccountProcessService)
        {
            _userManager = userManager;
            _customerAccountProcessService= customerAccountProcessService;

        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(SendMoneyForCustomerAccountProcessDto sendMoneyForCustomerAccountProcessDto)
        {
            var context = new Context();
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var receiverAccountNumberID = context.CustomerAccounts.Where(a => a.CustomerAccountNumber == sendMoneyForCustomerAccountProcessDto.RecieverAccountNumber)
                .Select(b => b.CustomerAccountID).FirstOrDefault();

            sendMoneyForCustomerAccountProcessDto.SenderID = user.Id;
            sendMoneyForCustomerAccountProcessDto.ProcessDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            sendMoneyForCustomerAccountProcessDto.ProcessType = "Pay";
            sendMoneyForCustomerAccountProcessDto.ReceiverID = receiverAccountNumberID;

            var values = new CustomerAccountProcess();
            values.ProcessDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            values.SenderID = 1;
            values.ReceiverID = receiverAccountNumberID;
            values.ProcessType = "Pay";
            values.Amount = sendMoneyForCustomerAccountProcessDto.Amount;
            
            //context.CustomerAccountProcesse.Add(values);
            //context.SaveChanges();
            _customerAccountProcessService.TInsert(values);


            return RedirectToAction("Index", "Deneme");
        }
    }
}
