using KayraCQRSMediator.Features.CQRS.Commands.CategoryCommands;
using KayraCQRSMediator.Features.CQRS.Handlers.CategoryHandlers;
using KayraCQRSMediator.Features.CQRS.Queries.CategoryQueries;
using KayraCQRSMediator.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace KayraCQRSMediator.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController(GetCategoryQueryHandler _getCategoryQueryHandler, GetCategoryByIdQueryHandler _getCategoryByIdQueryHandler,
        CreateCategoryCommandHandler _createCategoryCommandHandler,
        RemoveCategoryCommandHandler _removeCategoryCommandHandler,
        UpdateCategoryCommandHandler _updateCategoryCommandHandler) : Controller
    {

        public async Task<IActionResult> Index()
        {
            var values = await _getCategoryQueryHandler.Handle();
            return View(values);
        }

        [HttpGet]

        public async Task<IActionResult> UpdateCategory(int id)
        {
            var category = await _getCategoryByIdQueryHandler.Handle(new GetCategoryByIdQuery(id));
            return View(category);
        }

        [HttpPost]

        public async Task<IActionResult> UpdateCategory(UpdateCategoryCommand command)
        {
            await _updateCategoryCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> CreateCategory()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryCommand command)
        {
           
            await _createCategoryCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _removeCategoryCommandHandler.Handle(new RemoveCategoryCommand(id));
            return RedirectToAction("Index");
        }
    }
}
