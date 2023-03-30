using System;

namespace CleanApp.Domain.Entities
{
    public class Measurement
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public DateTime TakenUtc { get; set; }
        public int SerieId { get; set; }

        public virtual Serie Serie { get; set; }
    }
}
