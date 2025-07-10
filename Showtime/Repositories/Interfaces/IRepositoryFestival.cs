using Showtime.Entities;
using static Showtime.Components.Pages.Festivals.Lineup;


namespace Showtime.Repositories.Interfaces
{
    public interface IRepositoryFestival : IRepositoryBase<Festival>
    {
        Task<IEnumerable<Festival>> GetFestivalsByDateRange(DateTime startDate, DateTime endDate);
        Task<IEnumerable<Festival>> GetFestivalsByLocationAsync(string location);

        Task<Festival?> GetByIdWithBandsAsync(Guid id);


    }
}
