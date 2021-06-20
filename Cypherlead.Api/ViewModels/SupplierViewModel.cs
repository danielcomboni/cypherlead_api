using System.Text.Json;

namespace Cypherlead.Api.ViewModels
{
    public class SupplierViewModel : BaseViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public JsonDocument ExtraDetails { get; set; }
    }
}
