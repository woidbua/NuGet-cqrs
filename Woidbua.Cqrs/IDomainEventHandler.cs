using MediatR;

namespace Woidbua.Cqrs;

public interface IDomainEventHandler<in T> : INotificationHandler<T> where T : IDomainEvent
{
}
