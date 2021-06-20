using Cypherlead.Api.Data;
using Cypherlead.Api.Models;
using Microsoft.Extensions.Logging;

namespace Cypherlead.Api.Repositories.Specifics
{
    public class SupplierRepository : GeneralRepository<Supplier>, ISupplierRepository
    {
        public SupplierRepository(ApplicationDbContext context, ILogger<Supplier> logger) : base(context,logger)
        {

        }
    }
}
