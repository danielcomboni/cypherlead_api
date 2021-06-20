using Cypherlead.Api.Data;
using Cypherlead.Api.Models;
using Microsoft.Extensions.Logging;

namespace Cypherlead.Api.Repositories.Specifics
{
    public class CategoryRepository : GeneralRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext context, ILogger<Category> logger) : base(context,logger)
        {

        }
    }
}
