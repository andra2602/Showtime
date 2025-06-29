using Microsoft.EntityFrameworkCore;
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

        // Returns all bookings for a given festival.
        public async Task<IEnumerable<Booking>> GetBookingsByFestivalId(Guid festivalId)
        {
            return await _dbSet
                .Where(b => b.FestivalId == festivalId)
                .ToListAsync();
        }

        // Returns all bookings for a given range
        public async Task<IEnumerable<Booking>> GetBookingsByDateRange(DateTime start, DateTime end)
        {
            return await _dbSet
                .Where(b => b.Date >= start && b.Date <= end)
                .ToListAsync();
        }
        
        // Returns the total amount collected from bookings for a given festival
        public async Task<float> GetTotalRevenueForFestival(Guid festivalId)
        {
            return await _dbSet
                .Where(b => b.FestivalId == festivalId)
                .SumAsync(b => b.Price);
        }

        public async Task<int> GetBookingCountForFestival(Guid festivalId)
        {
            return await _dbSet
                .CountAsync(b => b.FestivalId == festivalId);
        }

    }
}
