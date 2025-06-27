using System.ComponentModel.DataAnnotations;
namespace Showtime.Entities
{
    public class Booking
    {
        [Key]
        public Guid Id { get; set; }
      
        public DateTime Date { get; set; }
    
        public float Price { get; set; }

        public Festival ?Festival { get; set; }
        public Guid FestivalId { get; set; }

        //public FestivalUser FestivalUser { get; set; }
        //public Guid FestivalUserId { get; set; }
    }
}
