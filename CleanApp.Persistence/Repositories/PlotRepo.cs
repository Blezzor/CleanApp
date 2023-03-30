using CleanApp.Application.Common.Interfaces;
using CleanApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanApp.Persistence.Repositories
{
    public class PlotRepo : Repository<Plot>, IPlotRepo
    {
        public CleanContext CleanContext
        {
            get { return _dbContext as CleanContext; }
        }

        public PlotRepo(CleanContext cleanContext) : base(cleanContext)
        {
        }

        public async Task<List<Plot>> GetPlotsByPersonId(int personId)
        {
            var plots = await CleanContext.Plots.Where(x => x.PlotSeries.Any(p => p.Serie.PersonId == personId)).ToListAsync();

            return plots;
        }
    }
}
