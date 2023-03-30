using AutoMapper;
using CleanApp.Domain.Entities;
using System.Collections.Generic;

namespace CleanApp.Application.Common.Dto
{
    public class PlotDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<SerieDto> Series { get; set; }

        public PlotDetailDto()
        {
            Series = new List<SerieDto>();
        }
    }

    public class PlotDetailProfile : Profile
    {
        public PlotDetailProfile()
        {
            CreateMap<Plot, PlotDetailDto>().ForSourceMember(source => source.PlotSeries, opt => opt.DoNotValidate()).ReverseMap();
        }
    }
}
