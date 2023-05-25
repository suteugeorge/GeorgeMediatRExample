using System.ComponentModel;

namespace mediatorAPI.Protocol.Interfaces;

public interface IEventHandler<TRequest, TResponse>
{
    Task HandledEventArgs(TRequest request, TResponse response, CancellationToken cancellationToken = default);
}