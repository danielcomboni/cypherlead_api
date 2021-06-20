using Cypherlead.Api.Data;
using Cypherlead.Api.Models;
using Microsoft.Extensions.Logging;

namespace Cypherlead.Api.Repositories.Specifics
{
    public class ItemRepository : GeneralRepository<Item>, IItemRepository
    {
        public ItemRepository(ApplicationDbContext context, ILogger<Item> logger) : base(context,logger)
        {

        }
    }
}
