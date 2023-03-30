using AutoMapper;
using CleanApp.Domain.Entities;
using System.Collections.Generic;

namespace CleanApp.Application.Common.Dto
{
    public class SerieDto
    {
        public int Id { get; set; }
        public UnitDto Unit { get; set; }
        public List<MeasurementDto> Measurements { get; set; }
    }

    public class SerieProfile : Profile
    {
        public SerieProfile()
        {
            CreateMap<Serie, SerieDto>().ForMember(dest => dest.Unit, opt => opt.MapFrom(src => src.DisplayUnit)).ReverseMap();
        }
    }
}
