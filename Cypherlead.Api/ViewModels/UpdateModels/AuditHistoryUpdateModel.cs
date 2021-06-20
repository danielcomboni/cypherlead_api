using Cypherlead.Api.Models;
using System;


namespace Cypherlead.Api.ViewModels.UpdateModels
{
    public class AuditHistoryUpdateModel : BaseViewModel
    {
        public ActionPerformed Action { get; set; }
        public string Description { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
