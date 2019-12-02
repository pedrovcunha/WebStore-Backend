using System;
using AutoMapper;

namespace WebStore.Domain.Profiles
{
    public class ProductsProfile: Profile
    {
        public ProductsProfile()
        {
            CreateMap<Entities.Product, DTOs.ProductDto>();
            CreateMap<DTOs.ProductForCreationDto, Entities.Product>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()));
        }
    }
}
