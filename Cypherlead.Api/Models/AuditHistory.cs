using System;

namespace Cypherlead.Api.Models
{
    public class AuditHistory : BaseModel
    {
        public ActionPerformed Action { get; set; }
        public string Description { get; set; }
        public Guid UserId { get; set; }

    }
}
