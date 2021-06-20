using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace Cypherlead.Api.Models
{
    public class Supplier : BaseModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        
        public JsonDocument ExtraDetails { get; set; }

    }
}
