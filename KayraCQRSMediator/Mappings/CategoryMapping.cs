using AutoMapper;
using KayraCQRSMediator.DataAcces.Entities;
using KayraCQRSMediator.Features.CQRS.Results.CategoryResults;

namespace KayraCQRSMediator.Mappings
{
    public class CategoryMapping: Profile
    {
        public CategoryMapping()
        {
                CreateMap<Category, GetCategoryQueryResult>().ReverseMap();
        }
    }
}
