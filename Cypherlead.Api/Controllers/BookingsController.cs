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
    public class BookingsController : BaseController
    {
        private readonly IBookingService _service;
        private readonly ILogger<Booking> _logger;
        public BookingsController(IBookingService service, ILogger<Booking> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<BookingViewModel>> Get() => await _service.GetAllAsync();

        [HttpPost]
        public async Task<BookingCreateModel> Post([FromBody] BookingCreateModel model) => await _service.CreateAsync(model);

        [HttpPost]
        [Route("batch")]
        public async Task<IEnumerable<Booking>> PostBatch([FromBody] IEnumerable<Booking> models) => await _service.CreateBatchAsync(models);

        [HttpPut("{id}")]
        public async Task<BookingUpdateModel> Put(Guid id, [FromBody] BookingUpdateModel model) => await _service.UpdateAsync(model, id);

        [HttpDelete("{id}")]
        public async Task<int> Delete(Guid id) => await _service.DeleteAsync(id);
    }
}
