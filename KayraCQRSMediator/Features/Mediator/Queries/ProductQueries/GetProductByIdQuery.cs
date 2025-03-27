using KayraCQRSMediator.Features.Mediator.Results.ProductResults;
using MediatR;

namespace KayraCQRSMediator.Features.Mediator.Queries.ProductQueries
{
    public class GetProductByIdQuery(int id) : IRequest<GetProductByIdQueryResult>
    {
        public int Id { get; set; } = id;
    }
}
