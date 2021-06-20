namespace Cypherlead.Api.ViewModels.UpdateModels
{
    public class DiscountUpdateModel : BaseViewModel
    {
        public bool IsSalesDiscount { get; set; }
        public bool IsPurchasesDiscount { get; set; }
        public bool IsPercentage { get; set; }
        public bool SpecifiedAmount { get; set; }
        public decimal DiscountAmount { get; set; }
    }
}
