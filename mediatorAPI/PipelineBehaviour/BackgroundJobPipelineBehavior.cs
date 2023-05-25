using mediatorAPI;
using MediatR;

public class BackgroundJobPipelineBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
{
    private readonly EventDispatcher _eventDispatcher;

    public BackgroundJobPipelineBehavior(IMediator mediator, EventDispatcher eventDispatcher)
    {
        _eventDispatcher = eventDispatcher;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        var response = await next();

        //fire and forget
        Task.Run(() => _eventDispatcher.DispatchAsync(request, response));

        return response;
    }
}