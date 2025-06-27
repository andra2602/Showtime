using Showtime.Context;
using Showtime.Entities;
using Showtime.Repositories.Interfaces;

namespace Showtime.Repositories.Implementation
{
    public class RepositoryBooking : RepositoryBase<Booking>, IRepositoryBooking
    {
        public RepositoryBooking(ShowTimeContext context) : base(context)
        {
        }
    }
}
