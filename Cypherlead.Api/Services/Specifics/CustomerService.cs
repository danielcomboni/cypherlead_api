using AutoMapper;
using Cypherlead.Api.Models;
using Cypherlead.Api.Repositories.Specifics;
using Cypherlead.Api.ViewModels;
using Cypherlead.Api.ViewModels.CreateModels;
using Cypherlead.Api.ViewModels.UpdateModels;
using Microsoft.Extensions.Logging;

namespace Cypherlead.Api.Services.Specifics
{
    public class CustomerService : GeneralService<Customer, CustomerCreateModel, CustomerUpdateModel, CustomerViewModel>, ICustomerService
    {
        public CustomerService(ICustomerRepository repository, IMapper mapper, ILogger<Customer> logger) : base(repository, mapper, logger)
        {

        }
    }
}
