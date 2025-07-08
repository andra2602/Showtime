using Showtime.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Showtime.Repositories.Interfaces
{
    public interface IRepositoryFestivalBand : IRepositoryBase<FestivalBand>
    {
        Task<IEnumerable<FestivalBand>> GetFestivalLineup(Guid festivalId);

        Task UpdateFestivalLineup(Guid festivalId, IEnumerable<FestivalBand> newLineup);

    }
}