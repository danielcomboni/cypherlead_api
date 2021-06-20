using AutoMapper;
using Cypherlead.Api.Models;
using Cypherlead.Api.Repositories.Specifics;
using Cypherlead.Api.ViewModels;
using Cypherlead.Api.ViewModels.CreateModels;
using Cypherlead.Api.ViewModels.UpdateModels;
using Microsoft.Extensions.Logging;

namespace Cypherlead.Api.Services.Specifics
{
    public class SaleService : GeneralService<Sale, SaleCreateModel, SaleUpdateModel, SaleViewModel>, ISaleService
    {
        public SaleService(ISaleRepository repository, IMapper mapper, ILogger<Sale> logger) : base(repository, mapper, logger)
        {

        }
    }
}
