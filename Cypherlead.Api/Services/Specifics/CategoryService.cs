using AutoMapper;
using Cypherlead.Api.Models;
using Cypherlead.Api.Repositories.Specifics;
using Cypherlead.Api.ViewModels;
using Cypherlead.Api.ViewModels.CreateModels;
using Cypherlead.Api.ViewModels.UpdateModels;
using Microsoft.Extensions.Logging;

namespace Cypherlead.Api.Services.Specifics
{
    public class CategoryService : GeneralService<Category, CategoryCreateModel, CategoryUpdateModel, CategoryViewModel>, ICategoryService
    {
        public CategoryService(ICategoryRepository repository, IMapper mapper, ILogger<Category> logger) : base(repository, mapper, logger)
        {

        }
    }
}
