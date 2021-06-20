using AutoMapper;
using Cypherlead.Api.Models;
using Cypherlead.Api.Repositories.Specifics;
using Cypherlead.Api.ViewModels;
using Cypherlead.Api.ViewModels.CreateModels;
using Cypherlead.Api.ViewModels.UpdateModels;
using Microsoft.Extensions.Logging;

namespace Cypherlead.Api.Services.Specifics
{
    public class DiscountService : GeneralService<Discount, DiscountCreateModel, DiscountUpdateModel, DiscountViewModel>, IDiscountService
    {
        public DiscountService(IDiscountRepository repository, IMapper mapper, ILogger<Discount> logger) : base(repository, mapper, logger)
        {

        }
    }
}
