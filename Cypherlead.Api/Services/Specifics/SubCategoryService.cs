using AutoMapper;
using Cypherlead.Api.Models;
using Cypherlead.Api.Repositories.Specifics;
using Cypherlead.Api.ViewModels;
using Cypherlead.Api.ViewModels.CreateModels;
using Cypherlead.Api.ViewModels.UpdateModels;
using Microsoft.Extensions.Logging;

namespace Cypherlead.Api.Services.Specifics
{
    public class SubCategoryService : GeneralService<SubCategory, SubCategoryCreateModel, SubCategoryUpdateModel, SubCategoryViewModel>, ISubCategoryService
    {
        public SubCategoryService(ISubCategoryRepository repository, IMapper mapper, ILogger<SubCategory> logger) : base(repository, mapper, logger)
        {

        }
    }
}
