using KayraCQRSMediator.Features.CQRS.Results.CategoryResults;

namespace KayraCQRSMediator.Features.Mediator.Results.ProductResults
{
    public class GetProductsQueryResult
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public decimal ProductPrice { get; set; }
        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }

        public GetCategoryQueryResult Category { get; set; }
    }
}
