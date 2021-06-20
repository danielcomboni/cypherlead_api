using Cypherlead.Api.Models;
using Cypherlead.Api.Services.Specifics;
using Cypherlead.Api.ViewModels;
using Cypherlead.Api.ViewModels.CreateModels;
using Cypherlead.Api.ViewModels.UpdateModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cypherlead.Api.Controllers
{
    public class SuppliersController : BaseController
    {
        private readonly ISupplierService _service;
        private readonly ILogger<Supplier> _logger;
        public SuppliersController(ISupplierService service, ILogger<Supplier> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<SupplierViewModel>> Get() => await _service.GetAllAsync();

        [HttpGet("{id}")]
        public async Task<Supplier> Get(Guid id) => await _service.GetByIdAsync(id);

        [HttpPost]
        public async Task<SupplierCreateModel> Post([FromBody] SupplierCreateModel model)
        {
            return await _service.CreateAsync(model);
        }

        [HttpPut("{id}")]
        public async Task<SupplierUpdateModel> Put(Guid id, [FromBody] SupplierUpdateModel model)
        {
            return await _service.UpdateAsync(model, id);
        }

        [HttpDelete("{id}")]
        public async Task<int> Delete(Guid id) => await _service.DeleteAsync(id);

    }
}
