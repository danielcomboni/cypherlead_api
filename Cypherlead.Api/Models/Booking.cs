using System;

namespace Cypherlead.Api.Models
{
    public class Booking : BaseModel
    {
        public Guid ItemId { get; set; }
        public decimal Quantity { get; set; }
        public Pricing Pricing { get; set; }
        public decimal InitialDeposit { get; set; }
        public BalanceClearance BalanceClearance { get; set; }
        public Discount Discount { get; set; }

    }
}
