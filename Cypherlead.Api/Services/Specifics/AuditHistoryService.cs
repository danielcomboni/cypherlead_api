using AutoMapper;
using Cypherlead.Api.Models;
using Cypherlead.Api.Repositories.Specifics;
using Cypherlead.Api.ViewModels;
using Cypherlead.Api.ViewModels.CreateModels;
using Cypherlead.Api.ViewModels.UpdateModels;
using Microsoft.Extensions.Logging;

namespace Cypherlead.Api.Services.Specifics
{
    public class AuditHistoryService: GeneralService<AuditHistory, AuditHistoryCreateModel, AuditHistoryUpdateModel, AuditHistoryViewModel>, IAuditHistoryService
    {
        public AuditHistoryService(IAuditHistoryRepository repository, IMapper mapper, ILogger<AuditHistory> logger) : base(repository, mapper, logger)
        {

        }
    }
}
