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
    public class UsersController : BaseController
    {
        private readonly IUserService _service;
        private readonly ILogger<User> _logger;
        public UsersController(IUserService service, ILogger<User> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<UserViewModel>> Get()
        {
            return await _service.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<User> Get(Guid id) => await _service.GetByIdAsync(id);

        [HttpPost]
        public async Task<UserCreateModel> Post([FromBody] UserCreateModel model)
        {
            return await _service.CreateAsync(model);
        }

        [HttpPut("{id}")]
        public async Task<UserUpdateModel> Put(Guid id, [FromBody] UserUpdateModel model)
        {
            return await _service.UpdateAsync(model, id);
        }

        [HttpDelete("{id}")]
        public async Task<int> Delete(Guid id) => await _service.DeleteAsync(id);

    }
}
