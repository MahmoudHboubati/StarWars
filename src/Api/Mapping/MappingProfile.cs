using Api.resources;
using AutoMapper;
using Domain.Entities;
using Domain.Entities.KeyLessEntities.SpeciesEntities;

namespace Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<People, PeopleDto>();
            CreateMap<SpeciesAggregate, SpeciesAggregateDto>();
        }
    }
}
