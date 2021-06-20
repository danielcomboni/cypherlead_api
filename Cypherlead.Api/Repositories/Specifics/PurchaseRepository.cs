using Cypherlead.Api.Data;
using Cypherlead.Api.Models;
using Microsoft.Extensions.Logging;

namespace Cypherlead.Api.Repositories.Specifics
{
    public class PurchaseRepository : GeneralRepository<Purchase>, IPurchaseRepository
    {
        public PurchaseRepository(ApplicationDbContext context, ILogger<Purchase> logger) : base(context,logger)
        {

        }
    }
}
