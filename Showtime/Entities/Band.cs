using Showtime.Enums;
using System.ComponentModel.DataAnnotations;

namespace Showtime.Entities
{
    public class Band
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Band name is required.")]
        public string Name { get; set; } = string.Empty;
        public Genre Genre { get; set; }
        public ICollection<FestivalBand> FestivalBands { get; set; } = [];


    }
}
