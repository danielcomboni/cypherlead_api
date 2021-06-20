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
    public class CategoriesController : BaseController
    {
        private readonly ICategoryService _service;
        private readonly ILogger<Category> _logger;
        public CategoriesController(ICategoryService service, ILogger<Category> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<CategoryViewModel>> Get() => await _service.GetAllAsync();

        [HttpGet("{id}")]
        public async Task<Category> Get(Guid id) => await _service.GetByIdAsync(id);

        [HttpPost]
        public async Task<CategoryCreateModel> Post([FromBody] CategoryCreateModel model)
        {
            return await _service.CreateAsync(model);
        }

        [HttpPut("{id}")]
        public async Task<CategoryUpdateModel> Put(Guid id, [FromBody] CategoryUpdateModel model)
        {
            return await _service.UpdateAsync(model, id);
        }

        [HttpDelete("{id}")]
        public async Task<int> Delete(Guid id) => await _service.DeleteAsync(id);

    }
}
