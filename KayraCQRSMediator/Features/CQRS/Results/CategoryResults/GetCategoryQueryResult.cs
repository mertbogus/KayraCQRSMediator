using KayraCQRSMediator.DataAcces.Entities;

namespace KayraCQRSMediator.Features.CQRS.Results.CategoryResults
{
    public class GetCategoryQueryResult
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public string ImageUrl { get; set; }

        public IList<Product> Products { get; set; }
    }
}
