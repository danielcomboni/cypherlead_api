using AutoMapper;
using Cypherlead.Api.Models;
using Cypherlead.Api.Repositories.Specifics;
using Cypherlead.Api.ViewModels;
using Cypherlead.Api.ViewModels.CreateModels;
using Cypherlead.Api.ViewModels.UpdateModels;
using Microsoft.Extensions.Logging;

namespace Cypherlead.Api.Services.Specifics
{
    public class PricingService : GeneralService<Pricing, PricingCreateModel, PricingUpdateModel, PricingViewModel>, IPricingService
    {
        public PricingService(IPricingRepository repository, IMapper mapper, ILogger<Pricing> logger) : base(repository, mapper, logger)
        {

        }
    }
}
