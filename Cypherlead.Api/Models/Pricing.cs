using System;

namespace Cypherlead.Api.Models
{
    public class Pricing : BaseModel
    {
        public Item Item { get; set; }
        public Guid ItemId { get; set; }
        public decimal Price { get; set; }

    }
}
