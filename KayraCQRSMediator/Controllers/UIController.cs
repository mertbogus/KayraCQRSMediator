using Microsoft.AspNetCore.Mvc;

namespace KayraCQRSMediator.Controllers
{
    public class UIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
