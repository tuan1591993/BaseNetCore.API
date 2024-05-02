using BaseNetCore.Application.Test.Queries.TestAPI;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BaseNetCore.API.Controllers
{
    [Route("api/v1/[controller]/[action]")]
    [ApiController]
    public class HomeController : BaseController
    {
        [HttpGet]
        public async Task<bool> TestAPI() => await Mediator.Send(new TestAPIQuery());
    }
}
