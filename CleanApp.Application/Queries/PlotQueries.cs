using AutoMapper;
using CleanApp.Application.Common.Dto;
using CleanApp.Application.Common.Interfaces;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanApp.Application.Queries
{
    #region Query
    public class PlotQueries
    {

        public class PlotSingle : IRequest<PlotDetailDto>
        {
            public int Id { get; init; }
        }
        public class PlotAll : IRequest<List<PlotDetailDto>>
        {

        }
    }
    #endregion

    #region Handler
    public class PlotQueryHandlers : IRequestHandler<PlotQueries.PlotSingle, PlotDetailDto>, IRequestHandler<PlotQueries.PlotAll, List<PlotDetailDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAuthorizationService _authorization;
        private readonly IMapper _mapper;

        public PlotQueryHandlers(IUnitOfWork unitOfWork, IAuthorizationService authorization, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _authorization = authorization;
            _mapper = mapper;
        }

        public async Task<PlotDetailDto> Handle(PlotQueries.PlotSingle request, CancellationToken cancellationToken)
        {
            PlotDetailDto plotDto = new();

            return plotDto;
        }

        public async Task<List<PlotDetailDto>> Handle(PlotQueries.PlotAll request, CancellationToken cancellation)
        {
            List<PlotDetailDto> plotDtos = new();

            return plotDtos;
        }
    }
    #endregion
}
