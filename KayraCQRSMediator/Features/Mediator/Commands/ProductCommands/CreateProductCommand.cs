using MediatR;

namespace KayraCQRSMediator.Features.Mediator.Commands.ProductCommands
{
    public class CreateProductCommand:IRequest
    {
        public string ProductName { get; set; }

        public decimal ProductPrice { get; set; }
        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }
    }
}
