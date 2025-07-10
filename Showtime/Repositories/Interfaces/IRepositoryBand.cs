using Showtime.Entities;
using Showtime.Enums;

namespace Showtime.Repositories.Interfaces
{
    public interface IRepositoryBand : IRepositoryBase<Band>
    {
        Task<IEnumerable<Band>> GetByGenre(Genre genre);

    }
}
