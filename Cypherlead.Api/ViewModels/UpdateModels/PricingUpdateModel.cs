using Cypherlead.Api.Models;
using System;

namespace Cypherlead.Api.ViewModels.UpdateModels
{
    public class PricingUpdateModel : BaseViewModel
    {
        public Item Item { get; set; }
        public Guid ItemId { get; set; }
        public decimal Price { get; set; }
    }
}
