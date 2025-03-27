using KayraCQRSMediator.DataAcces.Entities;
using KayraCQRSMediator.Features.Mediator.Results.ProductResults;

namespace KayraCQRSMediator.Features.CQRS.Results.CategoryResults
{
    public class GetCategoryQueryResult
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public string ImageUrl { get; set; }

        public IList<GetProductsQueryResult> Products { get; set; }
    }
}
