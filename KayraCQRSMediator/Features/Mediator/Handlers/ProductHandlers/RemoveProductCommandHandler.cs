using AutoMapper;
using KayraCQRSMediator.DataAcces.Entities;
using KayraCQRSMediator.Features.Mediator.Commands.ProductCommands;
using KayraCQRSMediator.Repositories;
using MediatR;
using NuGet.Protocol.Plugins;

namespace KayraCQRSMediator.Features.Mediator.Handlers.ProductHandlers
{
    public class RemoveProductCommandHandler(IRepository<Product> _repository, IMapper _mapper) : IRequestHandler<RemoveProductCommand>
    {
        public async Task Handle(RemoveProductCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(request.Id);
        }
    }
}
