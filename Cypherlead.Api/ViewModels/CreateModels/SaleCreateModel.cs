using Cypherlead.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cypherlead.Api.ViewModels.CreateModels
{
    public class SaleCreateModel : BaseViewModel
    {
        public Guid ItemId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal IsCredit { get; set; }
        public BalanceClearance BalanceClearance { get; set; }
        public Discount Discount { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
