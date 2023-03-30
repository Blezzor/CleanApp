using CleanApp.Application.Commands;
using CleanApp.Application.Common.Dto;
using CleanApp.Application.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanApp.API.Controllers
{
    public class PlotController : BaseApiController
    {
        [HttpGet("{id:int}")]
        public async Task<ActionResult<PlotDetailDto>> Get(int id)
        {
            return await Mediator.Send(new PlotQueries.PlotSingle { Id = id });
        }

        [HttpGet]
        public async Task<ActionResult<List<PlotDetailDto>>> GetAll()
        {
            return await Mediator.Send(new PlotQueries.PlotAll());
        }

        [HttpPost]
        public async Task<ActionResult<PlotDetailDto>> Create([FromBody] PlotCommands.PlotCreate command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut]
        public async Task<ActionResult<PlotDetailDto>> Update([FromBody] PlotCommands.PlotUpdate command)
        {
            return await Mediator.Send(command);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            await Mediator.Send(new PlotCommands.PlotDelete { Id = id });

            return NoContent();
        }
    }
}
