using AutoMapper;
using CleanApp.Domain.Entities;

namespace CleanApp.Application.Common.Dto
{
    public class MeasurementUnitDto
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Quantity { get; set; }
    }
    public class MeasurementUnitProfile : Profile
    {
        public MeasurementUnitProfile()
        {
            CreateMap<MeasurementUnit, MeasurementUnitDto>().ReverseMap();
        }
    }
}
