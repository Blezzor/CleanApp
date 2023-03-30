using AutoMapper;
using CleanApp.Domain.Entities;
using System;

namespace CleanApp.Application.Common.Dto
{
    public class MeasurementDto
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public DateTime TakenUtc { get; set; }
        public int SerieId { get; set; }
    }
    public class MeasurementProfile : Profile
    {
        public MeasurementProfile()
        {
            CreateMap<Measurement, MeasurementDto>().ReverseMap();
        }
    }
}
