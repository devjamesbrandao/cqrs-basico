using System.Threading.Tasks;
using CQRS.Commands.Request;
using CQRS.Commands.Response;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    [HttpPost(Name = "CQRS")]
    public Task<CreateCustomerResponse> Create(
        [FromBody] CreateCustomerRequest command,
        [FromServices] IMediator mediator
    )
    {
        return mediator.Send(command);
    }
}
