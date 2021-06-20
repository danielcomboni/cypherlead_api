using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cypherlead.Api.ViewModels.CreateModels
{
    public class DiscountCreateModel : BaseViewModel
    {
        public bool IsSalesDiscount { get; set; }
        public bool IsPurchasesDiscount { get; set; }
        public bool IsPercentage { get; set; }
        public bool SpecifiedAmount { get; set; }
        public decimal DiscountAmount { get; set; }
    }
}
