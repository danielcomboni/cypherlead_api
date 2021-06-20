using Cypherlead.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Cypherlead.Api.ViewModels.CreateModels
{
    public class ItemCreateModel : BaseViewModel
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
