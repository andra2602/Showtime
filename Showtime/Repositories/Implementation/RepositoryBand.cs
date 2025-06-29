using Microsoft.EntityFrameworkCore;
using Showtime.Context;
using Showtime.Entities;
using Showtime.Enums;
using Showtime.Repositories.Interfaces;

namespace Showtime.Repositories.Implementation
{
    public class RepositoryBand : RepositoryBase<Band>, IRepositoryBand
    {
        public RepositoryBand(ShowTimeContext context) : base(context)
        {

        }

        // Returns all bands for a given genre
        public async Task<IEnumerable<Band>> GetByGenre(Genre genre)
        {
            return await _dbSet.Where(e => e.Genre == genre).ToListAsync();
        }

        // Returns all bands for a specified festival
        public async Task<IEnumerable<Band>> GetBandsFromFestival(Guid festivalId)
        {
            return await _dbSet
                .Where(b => b.Festivals.Any(f => f.Id == festivalId))
                .ToListAsync();
        }


    }
}
