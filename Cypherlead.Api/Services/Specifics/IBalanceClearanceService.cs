using Cypherlead.Api.Models;
using Cypherlead.Api.ViewModels;
using Cypherlead.Api.ViewModels.CreateModels;
using Cypherlead.Api.ViewModels.UpdateModels;

namespace Cypherlead.Api.Services.Specifics
{
    public interface IBalanceClearanceService : IGeneralService<BalanceClearance, BalanceClearanceCreateModel, BalanceClearanceUpdateModel, BalanceClearanceViewModel>
    {
    }
}
