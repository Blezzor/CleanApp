using CleanApp.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanApp.Application.Common.Interfaces
{
    public interface IPlotRepo : IRepository<Plot>
    {
        Task<List<Plot>> GetPlotsByPersonId(int personId);
    }
}
