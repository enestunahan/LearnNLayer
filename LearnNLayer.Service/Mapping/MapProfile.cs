using AutoMapper;
using LearnNLayer.Core.DTOs;
using LearnNLayer.Core.Models;

namespace LearnNLayer.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
             CreateMap<Product, ProductDto>().ReverseMap();
             CreateMap<Category, CategoryDto>().ReverseMap();
             CreateMap<ProductFeature, ProductFeatureDto>().ReverseMap();
             CreateMap<ProductUpdateDto, Product>();
        }
      
    }
}
