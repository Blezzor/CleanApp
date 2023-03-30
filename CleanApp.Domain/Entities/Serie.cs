using System.Collections.Generic;

namespace CleanApp.Domain.Entities
{
    public class Serie
    {
        public Serie()
        {
            Measurements = new HashSet<Measurement>();
            PlotSeries = new HashSet<PlotSerie>();
        }

        public int Id { get; set; }
        public int PersonId { get; set; }
        public int MeasurementUnitId { get; set; }
        public int DisplayUnitId { get; set; }

        public virtual MeasurementUnit MeasurementUnit { get; set; }
        public virtual DisplayUnit DisplayUnit { get; set; }
        public virtual ICollection<Measurement> Measurements { get; set; }
        public virtual ICollection<PlotSerie> PlotSeries { get; set; }
    }
}
