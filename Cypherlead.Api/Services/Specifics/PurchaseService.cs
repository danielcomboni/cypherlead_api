using AutoMapper;
using Cypherlead.Api.Models;
using Cypherlead.Api.Repositories.Specifics;
using Cypherlead.Api.ViewModels;
using Cypherlead.Api.ViewModels.CreateModels;
using Cypherlead.Api.ViewModels.UpdateModels;
using Microsoft.Extensions.Logging;

namespace Cypherlead.Api.Services.Specifics
{
    public class PurchaseService : GeneralService<Purchase, PurchaseCreateModel, PurchaseUpdateModel, PurchaseViewModel>, IPurchaseService
    {
        public PurchaseService(IPurchaseRepository repository, IMapper mapper, ILogger<Purchase> logger) : base(repository, mapper, logger)
        {

        }
    }
}
