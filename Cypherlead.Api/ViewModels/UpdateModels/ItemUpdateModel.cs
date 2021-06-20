using Cypherlead.Api.Models;
using System;
using System.Text.Json;

namespace Cypherlead.Api.ViewModels.UpdateModels
{
    public class ItemUpdateModel : BaseViewModel
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public Guid CategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
        public Guid SubCategoryId { get; set; }

        public string SerialNumber { get; set; }

        // to store array of base64's containing sample image of this item
        // TODO ... A way to make it faster will have to be deviced
        public string[] SampleImages { get; set; }
        public JsonDocument ExtraDetails { get; set; }
    }
}
