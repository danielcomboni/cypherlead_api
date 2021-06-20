namespace Cypherlead.Api.Models
{
    public class Discount : BaseModel
    {
        public bool IsSalesDiscount { get; set; }
        public bool IsPurchasesDiscount { get; set; }
        public bool IsPercentage { get; set; }
        public bool SpecifiedAmount { get; set; }
        public decimal DiscountAmount { get; set; }

    }
}
