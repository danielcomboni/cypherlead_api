using AutoMapper;
using Cypherlead.Api.Models;
using Cypherlead.Api.Repositories.Specifics;
using Cypherlead.Api.ViewModels;
using Cypherlead.Api.ViewModels.CreateModels;
using Cypherlead.Api.ViewModels.UpdateModels;
using Microsoft.Extensions.Logging;

namespace Cypherlead.Api.Services.Specifics
{
    public class ItemService : GeneralService<Item, ItemCreateModel, ItemUpdateModel, ItemViewModel>, IItemService
    {
        public ItemService(IItemRepository repository, IMapper mapper, ILogger<Item> logger) : base(repository, mapper, logger)
        {

        }
    }
}
