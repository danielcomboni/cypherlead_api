using AutoMapper;
using Cypherlead.Api.Models;
using Cypherlead.Api.Repositories.Specifics;
using Cypherlead.Api.ViewModels;
using Cypherlead.Api.ViewModels.CreateModels;
using Cypherlead.Api.ViewModels.UpdateModels;
using Microsoft.Extensions.Logging;

namespace Cypherlead.Api.Services.Specifics
{
    public class BalanceClearanceService : GeneralService<BalanceClearance, BalanceClearanceCreateModel, BalanceClearanceUpdateModel, BalanceClearanceViewModel>, IBalanceClearanceService
    {
        public BalanceClearanceService(IBalanceClearanceRepository repository, IMapper mapper, ILogger<BalanceClearance> logger) : base(repository, mapper, logger)
        {

        }
    }
}
