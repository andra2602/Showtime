using System.ComponentModel.DataAnnotations;

namespace Showtime.Entities
{
    public class Festival
    {
        [Key]
        public Guid Id { get; set; }

        public string Location { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;
       
        public DateTime ?StartDate { get; set; }
       
        public DateTime ?EndDate { get; set; }

        public string Description { get; set; } = string.Empty;

        public ICollection<Band> Bands { get; set; } = [];
        public ICollection<Booking> Bookings { get; set; } = [];

    }
}
