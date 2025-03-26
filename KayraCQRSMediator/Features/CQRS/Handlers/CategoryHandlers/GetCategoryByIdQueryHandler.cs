using KayraCQRSMediator.DataAcces.Entities;
using KayraCQRSMediator.Features.CQRS.Queries.CategoryQueries;
using KayraCQRSMediator.Features.CQRS.Results.CategoryResults;
using KayraCQRSMediator.Repositories;

namespace KayraCQRSMediator.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly IRepository<Category> _repository;

        public GetCategoryByIdQueryHandler()
        {
        }

        public GetCategoryByIdQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery query)
        {
            var category = await _repository.GetByIdAsync(query.Id);
            return new GetCategoryByIdQueryResult
            {
                CategoryId = category.CategoryId,
                CategoryName = category.CategoryName,
                ImageUrl = category.ImageUrl,
                
            };
        }

        internal async Task Handle(GetCategoryByIdQueryHandler getCategoryByIdQueryHandler)
        {
            throw new NotImplementedException();
        }
    }
}
