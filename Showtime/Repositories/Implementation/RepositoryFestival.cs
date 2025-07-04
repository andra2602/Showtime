using Microsoft.EntityFrameworkCore;
using Showtime.Context;
using Showtime.Entities;
using Showtime.Repositories.Interfaces;

namespace Showtime.Repositories.Implementation
{
    public class RepositoryFestival : RepositoryBase<Festival>, IRepositoryFestival
    {
        public RepositoryFestival(ShowTimeContext context) : base(context)
        {
        }

        // Returns all festivals for a given range
        public async Task<IEnumerable<Festival>> GetFestivalsByDateRange(DateTime startDate, DateTime endDate)
        {
            return await _context.Festivals
                .Where(f => f.StartDate >= startDate && f.EndDate <= endDate)
                .ToListAsync();
        }
        // Returns all festivals for a specified location
        public async Task<IEnumerable<Festival>> GetFestivalsByLocationAsync(string location)
        {
            return await _context.Festivals
                .Where(f => f.Location.ToLower().Contains(location.ToLower()))
                .ToListAsync();
        }

       


    }
}
