using KayraCQRSMediator.Features.Mediator.Results.ProductResults;
using MediatR;

namespace KayraCQRSMediator.Features.Mediator.Queries.ProductQueries
{
    public class GetProductsQuery: IRequest<List<GetProductsQueryResult>>
    {
    }
}
