using AutoMapper;
using KayraCQRSMediator.DataAcces.Entities;
using KayraCQRSMediator.Features.Mediator.Commands.ProductCommands;
using KayraCQRSMediator.Repositories;
using MediatR;

namespace KayraCQRSMediator.Features.Mediator.Handlers.ProductHandlers
{
    public class UpdateProductCommandHandler(IRepository<Product> _repository, IMapper _mapper) : IRequestHandler<UpdateProductCommand>
    {
        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product=_mapper.Map<Product>(request);
            await _repository.UpdateAsync(product);
        }
    }
}
