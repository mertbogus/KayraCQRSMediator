using KayraCQRSMediator.DataAcces.Entities;
using KayraCQRSMediator.Features.CQRS.Commands.CategoryCommands;
using KayraCQRSMediator.Repositories;

namespace KayraCQRSMediator.Features.CQRS.Handlers.CategoryHandlers
{
    public class CreateCategoryCommandHandler(IRepository<Category> _repository)
    {
        public async Task Handle(CreateCategoryCommand command)
        {
            var category = new Category
            {
                CategoryName = command.CategoryName,
                ImageUrl = command.ImageUrl,
            };
            await _repository.CreateAsync(category);
        }
    }
}
