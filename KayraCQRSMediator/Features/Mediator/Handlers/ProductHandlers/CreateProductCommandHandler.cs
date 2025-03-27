using AutoMapper;
using KayraCQRSMediator.DataAcces.Entities;
using KayraCQRSMediator.Features.Mediator.Commands.ProductCommands;
using KayraCQRSMediator.Repositories;
using MediatR;

namespace KayraCQRSMediator.Features.Mediator.Handlers.ProductHandlers
{
    public class CreateProductCommandHandler(IRepository<Product> _repository, IMapper _mapper) : IRequestHandler<CreateProductCommand>
    {
        public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Product>(request);
            await _repository.CreateAsync(product);
        }
    }
}
