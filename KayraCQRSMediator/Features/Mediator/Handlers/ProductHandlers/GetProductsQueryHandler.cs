using AutoMapper;
using KayraCQRSMediator.DataAcces.Entities;
using KayraCQRSMediator.Features.Mediator.Queries.ProductQueries;
using KayraCQRSMediator.Features.Mediator.Results.ProductResults;
using KayraCQRSMediator.Repositories;
using MediatR;

namespace KayraCQRSMediator.Features.Mediator.Handlers.ProductHandlers
{
    public class GetProductsQueryHandler(IRepository<Product> _repository, IMapper _mapper) : IRequestHandler<GetProductsQuery, List<GetProductsQueryResult>>
    {
        public async Task<List<GetProductsQueryResult>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync(include:x=>x.Category);
            return  _mapper.Map<List<GetProductsQueryResult>>(values);
            
        }
    }
}
