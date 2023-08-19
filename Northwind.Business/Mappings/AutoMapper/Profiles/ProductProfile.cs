using AutoMapper;
using Northwind.Entities.Concrete;
using Northwind.Entities.Dtos;

namespace Northwind.Business.Mappings.AutoMapper.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductListDto, List<Product>>().ReverseMap();
            CreateMap<ProductAddDto, Product>().ReverseMap();
        }
    }
}
