using System;

namespace Cypherlead.Api.Models
{
    public class SubCategory : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public Guid CategoryId { get; set; }

    }
}
