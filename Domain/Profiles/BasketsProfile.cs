using System;
using AutoMapper;

namespace WebStore.Domain.Profiles
{
    public class BasketsProfile : Profile
    {
        public BasketsProfile()
        {
            CreateMap<Entities.Basket, DTOs.BasketDto>();
            CreateMap<DTOs.BasketForCreationDto, Entities.Basket>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()));
            CreateMap<Entities.Basket, DTOs.BasketDetailsDto>()
                .ForMember(dest => dest.Products, opt => opt.MapFrom(src => src.Products));
        }
    }
}
