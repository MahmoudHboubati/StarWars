using Api.resources;
using AutoMapper;
using Domain.Entities;

namespace Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<People, PeopleDto>();
        }
    }
}
