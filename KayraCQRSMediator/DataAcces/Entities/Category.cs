namespace KayraCQRSMediator.DataAcces.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public string ImageUrl { get; set; }

        public IList<Product> Products { get; set; }
    }
}
