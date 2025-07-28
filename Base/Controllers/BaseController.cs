using Microsoft.AspNetCore.Mvc;
using Solus.Microservice.Base.Responses;

namespace Solus.Microservice.Base.Controllers
{
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
        protected IActionResult OkResponse<T>(T data, string message = null)
            => Ok(new ApiResponse<T>(true, data, null, message));

        protected IActionResult ErrorResponse<T>(string error, string message = null)
            => BadRequest(new ApiResponse<T>(false, default, error, message));
    }
}