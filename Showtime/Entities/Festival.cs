using System.ComponentModel.DataAnnotations;

namespace Showtime.Entities
{
    public class Festival : IValidatableObject
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Location { get; set; } = string.Empty;

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public DateTime ?StartDate { get; set; }
        [Required]
        public DateTime ?EndDate { get; set; }

        public string Description { get; set; } = string.Empty;

        public ICollection<Booking> Bookings { get; set; } = [];
        public ICollection<FestivalBand> FestivalBands { get; set; } = [];


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (StartDate.HasValue && StartDate.Value < DateTime.Today.AddDays(7))
            {
                yield return new ValidationResult(
                    "Start date must be at least 7 days from today.",
                    new[] { nameof(StartDate) });
            }

            if (EndDate.HasValue && StartDate.HasValue && EndDate <= StartDate)
            {
                yield return new ValidationResult(
                    "End date must be after the start date.",
                    new[] { nameof(EndDate) });
            }
        }

    }
}
