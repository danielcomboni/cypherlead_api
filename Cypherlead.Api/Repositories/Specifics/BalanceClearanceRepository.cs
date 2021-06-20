using Cypherlead.Api.Data;
using Cypherlead.Api.Models;
using Microsoft.Extensions.Logging;

namespace Cypherlead.Api.Repositories.Specifics
{
    public class BalanceClearanceRepository : GeneralRepository<BalanceClearance>, IBalanceClearanceRepository
    {
        public BalanceClearanceRepository(ApplicationDbContext context, ILogger<BalanceClearance> logger) : base(context, logger)
        {

        }
    }
}
