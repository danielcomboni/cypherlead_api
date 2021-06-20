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
    public class DiscountsController : BaseController
    {
        private readonly IDiscountService _service;
        private readonly ILogger<Discount> _logger;
        public DiscountsController(IDiscountService service, ILogger<Discount> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<DiscountViewModel>> Get()
        {
            return await _service.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<Discount> Get(Guid id) => await _service.GetByIdAsync(id);

        [HttpPost]
        public async Task<DiscountCreateModel> Post([FromBody] DiscountCreateModel model)
        {
            return await _service.CreateAsync(model);
        }

        [HttpPut("{id}")]
        public async Task<DiscountUpdateModel> Put(Guid id, [FromBody] DiscountUpdateModel model)
        {
            return await _service.UpdateAsync(model, id);
        }

        [HttpDelete("{id}")]
        public async Task<int> Delete(Guid id) => await _service.DeleteAsync(id);

    }
}
