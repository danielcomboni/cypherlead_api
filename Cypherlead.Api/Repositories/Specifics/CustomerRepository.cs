using Cypherlead.Api.Data;
using Cypherlead.Api.Models;
using Microsoft.Extensions.Logging;

namespace Cypherlead.Api.Repositories.Specifics
{
    public class CustomerRepository : GeneralRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext context, ILogger<Customer> logger) : base(context,logger)
        {

        }
    }
}
