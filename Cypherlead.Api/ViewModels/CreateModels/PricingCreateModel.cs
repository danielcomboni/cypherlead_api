using Cypherlead.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cypherlead.Api.ViewModels.CreateModels
{
    public class PricingCreateModel : BaseViewModel
    {
        public Item Item { get; set; }
        public Guid ItemId { get; set; }
        public decimal Price { get; set; }
    }
}
