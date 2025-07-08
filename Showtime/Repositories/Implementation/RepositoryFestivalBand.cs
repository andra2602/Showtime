using Showtime.Entities;
using Showtime.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Showtime.Context;

namespace Showtime.Repositories.Implementation
{
 
    public class RepositoryFestivalBand : RepositoryBase<FestivalBand>, IRepositoryFestivalBand
    {
        public RepositoryFestivalBand(ShowTimeContext context) : base(context)
        {
        }
        public async Task<IEnumerable<FestivalBand>> GetFestivalLineup(Guid festivalId)
        {
            return await _context.FestivalBands 
                .Where(fb => fb.FestivalId == festivalId)
                .Include(fb => fb.Band) 
                .OrderBy(fb => fb.Order) 
                .ToListAsync();
        }

        public async Task UpdateFestivalLineup(Guid festivalId, IEnumerable<FestivalBand> newLineup)
        {
           
            var existingLineup = await _context.FestivalBands
                .Where(fb => fb.FestivalId == festivalId)
                .ToListAsync();

            _context.FestivalBands.RemoveRange(existingLineup);

            await _context.FestivalBands.AddRangeAsync(newLineup);

            await _context.SaveChangesAsync();
        }
    }
}