using Cypherlead.Api.Models;
using System;

namespace Cypherlead.Api.ViewModels
{
    public class PurchaseViewModel : BaseViewModel
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
