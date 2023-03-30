using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanApp.Application.Common.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IPlotRepo Plot { get; }

        Task<int> CompleteAsync(CancellationToken cancellationToken = default);

        new void Dispose();
    }
}
