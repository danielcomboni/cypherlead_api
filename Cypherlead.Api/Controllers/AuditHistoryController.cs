using Cypherlead.Api.Models;
using Cypherlead.Api.Services.Specifics;
using Cypherlead.Api.ViewModels;
using Cypherlead.Api.ViewModels.CreateModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cypherlead.Api.Controllers
{
    public class AuditHistoryController : BaseController
    {
        private readonly IAuditHistoryService _service;
        private readonly ILogger<AuditHistory> _logger;
        public AuditHistoryController(IAuditHistoryService service, ILogger<AuditHistory> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<AuditHistoryViewModel>> GetAll()
        {
            return await _service.GetAllAsync();
        }

        [HttpPost]
        public async Task<AuditHistoryCreateModel> Post([FromBody] AuditHistoryCreateModel model)
        {
            return await _service.CreateAsync(model);
        }
    }
}
