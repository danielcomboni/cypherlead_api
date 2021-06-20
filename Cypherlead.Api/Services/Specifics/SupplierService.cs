using AutoMapper;
using Cypherlead.Api.Models;
using Cypherlead.Api.Repositories.Specifics;
using Cypherlead.Api.ViewModels;
using Cypherlead.Api.ViewModels.CreateModels;
using Cypherlead.Api.ViewModels.UpdateModels;
using Microsoft.Extensions.Logging;

namespace Cypherlead.Api.Services.Specifics
{
    public class SupplierService : GeneralService<Supplier, SupplierCreateModel, SupplierUpdateModel, SupplierViewModel>, ISupplierService
    {
        public SupplierService(ISupplierRepository repository, IMapper mapper, ILogger<Supplier> logger) : base(repository, mapper, logger)
        {

        }
    }
}
