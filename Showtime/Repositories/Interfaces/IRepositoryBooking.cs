using Showtime.Entities;

namespace Showtime.Repositories.Interfaces
{
    public interface IRepositoryBooking : IRepositoryBase<Booking>
    {
        Task<IEnumerable<Booking>> GetBookingsByFestivalId(Guid festivalId);
        Task<IEnumerable<Booking>> GetBookingsByDateRange(DateTime start, DateTime end);
        Task<float> GetTotalRevenueForFestival(Guid festivalId);
        Task<int> GetBookingCountForFestival(Guid festivalId);
    }
}
