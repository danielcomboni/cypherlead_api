using System.Text.Json;

namespace Cypherlead.Api.ViewModels.UpdateModels
{
    public class CustomerUpdateModel : BaseViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public JsonDocument ExtraDetails { get; set; }
    }
}
