using KayraCQRSMediator.DataAcces.Entities;
using KayraCQRSMediator.Features.CQRS.Results.CategoryResults;
using KayraCQRSMediator.Repositories;

namespace KayraCQRSMediator.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler
    {
        private readonly IRepository<Category> _repository;

        public GetCategoryQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCategoryQueryResult>> Handle()
        {
            var categories = await _repository.GetAllAsync();

           return categories.Select(category => new GetCategoryQueryResult
            {
                CategoryId = category.CategoryId,
                CategoryName = category.CategoryName,
                ImageUrl = category.ImageUrl,
                Products = category.Products,
            }).ToList(); ;

        }
    }
}
