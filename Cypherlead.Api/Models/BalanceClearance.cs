using System;

namespace Cypherlead.Api.Models
{
    public class BalanceClearance : BaseModel
    {
        public DateTime TimeOfClearan { get; set; }
        public Item Item { get; set; }
        public Guid ItemId { get; set; }
        public Pricing Pricing { get; set; }
        public Guid PricingId { get; set; }
        public decimal ActualPrice { get; set; }
        public decimal TotalCost { get; set; }
        public decimal Balance { get; set; }
        public decimal[] Clearances { get; set; }

    }
}
