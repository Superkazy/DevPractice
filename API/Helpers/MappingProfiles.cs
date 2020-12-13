using API.Dtos;
using AutoMapper;
using Core.Entities;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
            .ForMember(d => d.ProductBrands, o => o.MapFrom(s => s.ProductBrands.Name))
            .ForMember(d => d.ProductTypes, o => o.MapFrom(s => s.ProductTypes.Name))
            .ForMember(d => d.PictureUrl, o => o.MapFrom<ProductUrlResolver>());
        }
    }
}