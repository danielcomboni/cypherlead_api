using Cypherlead.Api.Data;
using Cypherlead.Api.Models;
using Microsoft.Extensions.Logging;

namespace Cypherlead.Api.Repositories.Specifics
{
    public class AuditHistoryRepository : GeneralRepository<AuditHistory>, IAuditHistoryRepository
    {
        public AuditHistoryRepository(ApplicationDbContext context, ILogger<AuditHistory> logger) : base(context,logger)
        {

        }
    }
}
