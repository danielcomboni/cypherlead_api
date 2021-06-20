using Cypherlead.Api.Data;
using Cypherlead.Api.Models;
using Microsoft.Extensions.Logging;

namespace Cypherlead.Api.Repositories.Specifics
{
    public class PricingRepository : GeneralRepository<Pricing>, IPricingRepository
    {
        public PricingRepository(ApplicationDbContext context, ILogger<Pricing> logger) : base(context,logger)
        {

        }
    }
}
