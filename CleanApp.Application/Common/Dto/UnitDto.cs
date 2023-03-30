using AutoMapper;
using CleanApp.Domain.Entities;

namespace CleanApp.Application.Common.Dto
{
    public class UnitDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public double? ConversionFactor { get; set; }
        public double? ConversionConstant { get; set; }
        public MeasurementUnitDto MeasurementUnit { get; set; }
    }

    public class UnitDtoProfile : Profile
    {
        public UnitDtoProfile()
        {
            CreateMap<DisplayUnit, UnitDto>().ReverseMap();
        }
    }
}
