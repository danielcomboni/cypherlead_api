using Cypherlead.Api.Models;
using System;


namespace Cypherlead.Api.ViewModels
{
    public class AuditHistoryViewModel
    {
        public ActionPerformed Action { get; set; }
        public string Description { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
