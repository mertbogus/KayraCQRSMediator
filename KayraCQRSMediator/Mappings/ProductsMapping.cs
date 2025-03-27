using AutoMapper;
using KayraCQRSMediator.DataAcces.Entities;
using KayraCQRSMediator.Features.CQRS.Commands.CategoryCommands;
using KayraCQRSMediator.Features.Mediator.Commands.ProductCommands;
using KayraCQRSMediator.Features.Mediator.Results.ProductResults;

namespace KayraCQRSMediator.Mappings
{
    public class ProductsMapping : Profile
    {
        public ProductsMapping()
        {
            CreateMap<Product, GetProductsQueryResult>().ReverseMap();
            CreateMap<Product, CreateProductCommand>().ReverseMap();
            CreateMap<Product, GetProductByIdQueryResult>().ReverseMap();
        }
    }
}
