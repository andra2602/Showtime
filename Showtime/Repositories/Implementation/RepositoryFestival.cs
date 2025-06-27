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
    }
}
