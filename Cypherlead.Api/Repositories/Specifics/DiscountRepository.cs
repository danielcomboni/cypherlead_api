using Cypherlead.Api.Data;
using Cypherlead.Api.Models;
using Microsoft.Extensions.Logging;

namespace Cypherlead.Api.Repositories.Specifics
{
    public class DiscountRepository : GeneralRepository<Discount>, IDiscountRepository
    {
        public DiscountRepository(ApplicationDbContext context, ILogger<Discount> logger) : base(context,logger)
        {

        }
    }
}
