using AutoMapper;
using CleanApp.Application.Common.Dto;
using CleanApp.Application.Common.Interfaces;
using FluentValidation;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CleanApp.Application.Commands
{
    #region Command
    public class PlotCommands
    {
        public class PlotCreate : IRequest<PlotDetailDto>
        {
            public string Name { get; init; }
            public int UnitId { get; init; }
        }
        public class PlotUpdate : IRequest<PlotDetailDto>
        {
            public int Id { get; init; }
            public string Name { get; init; }
        }
        public class PlotDelete : IRequest<Unit>
        {
            public int Id { get; init; }
        }
    }
    #endregion

    #region Validator
    public class PlotCreateValidator : AbstractValidator<PlotCommands.PlotCreate>
    {
        public PlotCreateValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .MaximumLength(30);

            RuleFor(x => x.UnitId)
                .GreaterThan(0);
        }
    }

    public class PlotUpdateValidator : AbstractValidator<PlotCommands.PlotUpdate>
    {
        public PlotUpdateValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0);

            RuleFor(x => x.Name)
                .NotEmpty()
                .MinimumLength(1)
                .MaximumLength(30);
        }
    }

    public class PlotDeleteValidator : AbstractValidator<PlotCommands.PlotDelete>
    {
        public PlotDeleteValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0);
        }
    }

    #endregion

    #region Handler
    public class PlotCommandHandlers : IRequestHandler<PlotCommands.PlotCreate, PlotDetailDto>, IRequestHandler<PlotCommands.PlotUpdate, PlotDetailDto>, IRequestHandler<PlotCommands.PlotDelete, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAuthorizationService _authorization;
        private readonly IMapper _mapper;

        public PlotCommandHandlers(IUnitOfWork unitOfWork, IAuthorizationService authorization, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _authorization = authorization;
            _mapper = mapper;
        }

        public async Task<PlotDetailDto> Handle(PlotCommands.PlotCreate request, CancellationToken cancellationToken)
        {
            PlotDetailDto plotDto = new();

            return plotDto;
        }

        public async Task<PlotDetailDto> Handle(PlotCommands.PlotUpdate request, CancellationToken cancellationToken)
        {
            PlotDetailDto plotDto = new();

            return plotDto;
        }

        public async Task<Unit> Handle(PlotCommands.PlotDelete request, CancellationToken cancellationToken)
        {
            return Unit.Value;
        }
    }
    #endregion
}
