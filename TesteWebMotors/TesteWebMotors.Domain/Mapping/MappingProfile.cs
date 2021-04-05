using AutoMapper;
using System;
using TesteWebMotors.Domain.Domain;
using TesteWebMotors.Entity.Entity;

namespace TesteWebMotors.Domain.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AnuncionWebMotorsModel,AnuncioWebMotorsEntity>();
            CreateMap<AnuncioWebMotorsEntity,AnuncionWebMotorsModel>();
        }
    }
}
