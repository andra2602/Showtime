namespace Showtime.Entities
{
    public class FestivalBand
    {
        public Festival Festival { get; set; } = null!;
        public Guid FestivalId { get; set; }

        public Band Band { get; set; } = null!;
        public Guid BandId { get; set; }

        public int Order { get; set; }
    }
}
