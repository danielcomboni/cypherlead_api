using Cypherlead.Api.Models;
using System;

namespace Cypherlead.Api.ViewModels.UpdateModels
{
    public class SubCategoryUpdateModel : BaseViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public Guid CategoryId { get; set; }
    }
}
