using mediatorAPI.Protocol.Interfaces;

namespace mediatorAPI;

public class EventDispatcher
{
    private readonly ILogger<EventDispatcher> _logger;
    private readonly IServiceProvider _serviceProvider;

    public EventDispatcher(ILogger<EventDispatcher> logger,
        IServiceProvider serviceProvider)
    {
        _logger = logger;
        _serviceProvider = serviceProvider;
    }

    public async Task DispatchAsync<TRequest, TResponse>(TRequest request, TResponse response)
    {
        try
        {
            // get event handlers
            var eventHandlers = _serviceProvider.GetServices<IEventHandler<TRequest, TResponse>>();

            // Start tasks for each handler
            var handlerTasks = eventHandlers.Select(handler => handler.HandledEventArgs(request, response));

            // Wait for all tasks to complete
            await Task.WhenAll(handlerTasks);
        }
        catch (Exception e)
        {
           _logger.LogError(e, $"Error while dispatching event {typeof(TRequest)}");
        }
    }
}