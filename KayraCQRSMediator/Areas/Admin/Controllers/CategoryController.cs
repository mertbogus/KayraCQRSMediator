using KayraCQRSMediator.Features.CQRS.Handlers.CategoryHandlers;
using KayraCQRSMediator.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace KayraCQRSMediator.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController(GetCategoryQueryHandler _getCategoryQueryHandler) : Controller
    {

        public async Task<IActionResult> Index()
        {
            var values = await _getCategoryQueryHandler.Handle();
            return View(values);
        }
    }
}
