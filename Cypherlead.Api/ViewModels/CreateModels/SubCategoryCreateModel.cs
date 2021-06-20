using Cypherlead.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cypherlead.Api.ViewModels.CreateModels
{
    public class SubCategoryCreateModel : BaseViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public Guid CategoryId { get; set; }
    }
}
