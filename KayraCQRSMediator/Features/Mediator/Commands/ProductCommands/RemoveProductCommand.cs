using MediatR;

namespace KayraCQRSMediator.Features.Mediator.Commands.ProductCommands
{
    public class RemoveProductCommand(int id):IRequest
    {
        public int Id { get; set; } = id;
    }
}
