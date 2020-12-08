using AutoMapper;
using SpoRT.Domain.Models;
using SpoRT.Persistence.Entities;

namespace SpoRT.Domain.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<SportEntity, Sport>().ReverseMap();
        }
    }
}