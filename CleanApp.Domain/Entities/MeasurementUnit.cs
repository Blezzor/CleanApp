using System.Collections.Generic;

namespace CleanApp.Domain.Entities
{
    public class MeasurementUnit
    {
        public MeasurementUnit()
        {
            Series = new HashSet<Serie>();
            DisplayUnits = new HashSet<DisplayUnit>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Quantity { get; set; }

        public virtual ICollection<Serie> Series { get; set; }
        public virtual ICollection<DisplayUnit> DisplayUnits { get; set; }
    }
}
