using System;

namespace Cypherlead.Api.Models
{
    public class Purchase : BaseModel
    {
        public Guid ItemId { get; set; }
        public decimal UnitCost { get; set; }
        public decimal Quantity { get; set; }
        public decimal TotalCost { get; set; }
        public decimal IsCredit { get; set; }
        public BalanceClearance BalanceClearance { get; set; }
        public Discount Discount { get; set; }

        public Guid SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        

    }
}
