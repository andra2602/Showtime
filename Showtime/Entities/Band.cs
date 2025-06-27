using Showtime.Enums;
using System.ComponentModel.DataAnnotations;

namespace Showtime.Entities
{
    public class Band
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Genre Genre { get; set; }

        public ICollection<Festival> Festivals { get; set; } = [];

    }
}
