using AutoMapper;
using KayraCQRSMediator.DataAcces.Entities;
using KayraCQRSMediator.Features.Mediator.Queries.ProductQueries;
using KayraCQRSMediator.Features.Mediator.Results.ProductResults;
using KayraCQRSMediator.Repositories;
using MediatR;
using NuGet.Protocol.Plugins;

namespace KayraCQRSMediator.Features.Mediator.Handlers.ProductHandlers
{
    public class GetProductByIdQueryHandler(IRepository<Product> _repository, IMapper _mapper) : IRequestHandler<GetProductByIdQuery, GetProductByIdQueryResult>
    {
        public async Task<GetProductByIdQueryResult> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<GetProductByIdQueryResult>(product);
        }
    }
}
