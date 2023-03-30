using CleanApp.Application.Common.Interfaces;
using CleanApp.Persistence.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace CleanApp.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CleanContext _cleanContext;

        public UnitOfWork(CleanContext cleanContext)
        {
            _cleanContext = cleanContext;
            Plot = new PlotRepo(_cleanContext);
        }


        public IPlotRepo Plot { get; private set; }


        public async Task<int> CompleteAsync(CancellationToken cancellationToken = default)
        {
            return await _cleanContext.SaveChangesAsync(cancellationToken);
        }
        public void Dispose()
        {
            _cleanContext.Dispose();
        }
    }
}
