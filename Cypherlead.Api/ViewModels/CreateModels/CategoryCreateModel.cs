using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cypherlead.Api.ViewModels.CreateModels
{
    public class CategoryCreateModel : BaseViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
