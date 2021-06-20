using AutoMapper;
using Cypherlead.Api.Models;
using Cypherlead.Api.Repositories.Specifics;
using Cypherlead.Api.ViewModels;
using Cypherlead.Api.ViewModels.CreateModels;
using Cypherlead.Api.ViewModels.UpdateModels;
using Microsoft.Extensions.Logging;

namespace Cypherlead.Api.Services.Specifics
{
    public class BookingService : GeneralService<Booking, BookingCreateModel, BookingUpdateModel, BookingViewModel>, IBookingService
    {
        public BookingService(IBookingRepository repository, IMapper mapper, ILogger<Booking> logger) : base(repository, mapper, logger)
        {

        }
    }
}
