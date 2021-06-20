using Cypherlead.Api.Data;
using Cypherlead.Api.Models;
using Microsoft.Extensions.Logging;

namespace Cypherlead.Api.Repositories.Specifics
{
    public class BookingRepository : GeneralRepository<Booking>, IBookingRepository
    {
        public BookingRepository(ApplicationDbContext context, ILogger<Booking> logger) : base(context,logger)
        {

        }
    }
}
