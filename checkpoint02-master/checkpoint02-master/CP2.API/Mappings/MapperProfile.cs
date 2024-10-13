using AutoMapper;
using CP2.API.Application.Dtos;
using CP2.API.Domain.Entities;

namespace CP2.API.Mappings;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<VendedorEntity, VendedorDto>().ReverseMap();
        CreateMap<FornecedorEntity, FornecedorDto>().ReverseMap();
    }
}