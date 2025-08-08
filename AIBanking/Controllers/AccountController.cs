using Microsoft.AspNetCore.Mvc;

namespace AIBanking.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
