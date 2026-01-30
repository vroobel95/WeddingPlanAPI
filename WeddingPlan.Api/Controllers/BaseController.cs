using MediatR;
using Microsoft.AspNetCore.Mvc;

[ApiController]
public abstract class BaseController : ControllerBase
{
    private IMediator? _mediator;

    protected IMediator Mediator =>
        _mediator ??= HttpContext.RequestServices.GetRequiredService<IMediator>();

    protected async Task<IActionResult> Send<TRequest>(TRequest request)
        where TRequest : IRequest
    {
        await Mediator.Send(request);
        return Ok();
    }

    protected async Task<IActionResult> Send<TResponse>(IRequest<TResponse> request)
    {
        var response = await Mediator.Send(request);
        return Ok(response);
    }
}
