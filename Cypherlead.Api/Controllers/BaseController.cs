using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cypherlead.Api.Controllers
{
    [AllowAnonymous]
    [Produces("application/json")]
    [ProducesResponseType(typeof(OkResult), 200)]
    [ProducesResponseType(typeof(NotFoundResult), 400)]
    [ProducesResponseType(typeof(UnauthorizedResult), 401)]
    [ProducesResponseType(500)]
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController : Controller
    {
    }
}
