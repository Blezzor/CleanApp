namespace CleanApp.Domain.Entities
{
    public class PlotSerie
    {
        public int Id { get; set; }
        public int SerieId { get; set; }
        public int PlotId { get; set; }

        public virtual Plot Plot { get; set; }
        public virtual Serie Serie { get; set; }
    }
}
