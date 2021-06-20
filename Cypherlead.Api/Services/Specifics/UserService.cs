using AutoMapper;
using Cypherlead.Api.Models;
using Cypherlead.Api.Repositories.Specifics;
using Cypherlead.Api.ViewModels;
using Cypherlead.Api.ViewModels.CreateModels;
using Cypherlead.Api.ViewModels.UpdateModels;
using Microsoft.Extensions.Logging;

namespace Cypherlead.Api.Services.Specifics
{
    public class UserService : GeneralService<User, UserCreateModel, UserUpdateModel, UserViewModel>, IUserService
    {
        public UserService(IUserRepository repository, IMapper mapper, ILogger<User> logger) : base(repository, mapper, logger)
        {

        }
    }
}
