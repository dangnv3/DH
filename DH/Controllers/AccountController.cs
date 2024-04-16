using Microsoft.AspNetCore.Mvc;

namespace DH.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return PartialView("Views/Shared/Login.cshtml");
        }
        public IActionResult Register()
        {
            return PartialView("Views/Shared/Register.cshtml");
        }
    }
}
