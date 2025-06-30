using Showtime.Entities;

namespace Showtime.Repositories.Interfaces
{
    public interface IRepositoryFestival : IRepositoryBase<Festival>
    {
        Task<IEnumerable<Festival>> GetFestivalsByDateRange(DateTime startDate, DateTime endDate);
        Task<IEnumerable<Festival>> GetFestivalsByLocationAsync(string location);
    }
}
