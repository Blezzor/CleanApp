using CleanApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanApp.Persistence
{
    public partial class CleanContext : DbContext
    {
        public CleanContext(DbContextOptions<CleanContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Plot> Plots { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
