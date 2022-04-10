using AutoMapper;
using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Application.DTOs;

namespace CleanArchMvc.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            
            CreateMap<Keys, KeysDTO>().ReverseMap();
        }
    }
}
