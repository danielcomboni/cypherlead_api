using Cypherlead.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cypherlead.Api.ViewModels.CreateModels
{
    public class PurchaseCreateModel : BaseViewModel
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
