using Cypherlead.Api.Data;
using Cypherlead.Api.Models;
using Microsoft.Extensions.Logging;

namespace Cypherlead.Api.Repositories.Specifics
{
    public class SaleRepository : GeneralRepository<Sale>, ISaleRepository
    {
        public SaleRepository(ApplicationDbContext context, ILogger<Sale> logger) : base(context,logger)
        {

        }
    }
}
