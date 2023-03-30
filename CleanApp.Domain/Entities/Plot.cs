using System.Collections.Generic;

namespace CleanApp.Domain.Entities
{
    public class Plot
    {
        public Plot()
        {
            PlotSeries = new HashSet<PlotSerie>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PlotSerie> PlotSeries { get; set; }
    }
}
