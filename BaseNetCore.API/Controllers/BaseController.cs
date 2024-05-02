using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BaseNetCore.API.Controllers
{
    public class BaseController : ControllerBase
    {
        private ISender _mediator = null!;

        protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();
    }
}