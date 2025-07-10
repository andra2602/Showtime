using System.ComponentModel.DataAnnotations;
namespace Showtime.Entities
{
    public class Booking
    {
        [Key]
        public Guid Id { get; set; }
      
        public DateTime Date { get; set; }
        public DateTime StartDate { get; set; }   // ziua de inceput rezervata 
        public DateTime EndDate { get; set; }     // ziua de final

        public float Price { get; set; }

        public Festival ?Festival { get; set; }
        public Guid FestivalId { get; set; }

        public Guid? UserId { get; set; }
        public ApplicationUser? User { get; set; }


    }
}
