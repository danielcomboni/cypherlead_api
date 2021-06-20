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
    public class SubCategoriesController : BaseController
    {
        private readonly ISubCategoryService _service;
        private readonly ILogger<SubCategory> _logger;
        public SubCategoriesController(ISubCategoryService service, ILogger<SubCategory> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<SubCategoryViewModel>> Get()
        {
            return await _service.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<SubCategory> Get(Guid id) => await _service.GetByIdAsync(id);

        [HttpPost]
        public async Task<SubCategoryCreateModel> Post([FromBody] SubCategoryCreateModel model)
        {
            return await _service.CreateAsync(model);
        }

        [HttpPut("{id}")]
        public async Task<SubCategoryUpdateModel> Put(Guid id, [FromBody] SubCategoryUpdateModel model)
        {
            return await _service.UpdateAsync(model, id);
        }

        [HttpDelete("{id}")]
        public async Task<int> Delete(Guid id) => await _service.DeleteAsync(id);

    }
}
