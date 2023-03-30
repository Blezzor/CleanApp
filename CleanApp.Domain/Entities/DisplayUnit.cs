using System.Collections.Generic;

namespace CleanApp.Domain.Entities
{
    public class DisplayUnit
    {
        public DisplayUnit()
        {
            Series = new HashSet<Serie>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public double? ConversionFactor { get; set; }
        public double? ConversionConstant { get; set; }
        public int MeasurementUnitId { get; set; }

        public virtual MeasurementUnit MeasurementUnit { get; set; }
        public virtual ICollection<Serie> Series { get; set; }
    }
}
