using Cypherlead.Api.Data;
using Cypherlead.Api.Models;
using Microsoft.Extensions.Logging;

namespace Cypherlead.Api.Repositories.Specifics
{
    public class UserRepository : GeneralRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context, ILogger<User> logger) : base(context,logger)
        {

        }
    }
}
