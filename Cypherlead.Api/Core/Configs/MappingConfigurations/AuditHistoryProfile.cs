using AutoMapper;
using Cypherlead.Api.Models;
using Cypherlead.Api.ViewModels;
using Cypherlead.Api.ViewModels.CreateModels;
using Cypherlead.Api.ViewModels.UpdateModels;

namespace Cypherlead.Api.Core.Configs.MappingConfigurations
{
    public class AuditHistoryProfile : Profile
    {
        public AuditHistoryProfile()
        {
            CreateMap<AuditHistory, AuditHistoryCreateModel>().ReverseMap();
            CreateMap<AuditHistory, AuditHistoryUpdateModel>().ReverseMap();
            CreateMap<AuditHistory, AuditHistoryViewModel>().ReverseMap();
        }
    }
}
