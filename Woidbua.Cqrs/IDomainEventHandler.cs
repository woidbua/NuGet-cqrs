using MediatR;

namespace Woidbua.Cqrs;

public interface IDomainEventHandler : INotificationHandler<IDomainEvent>
{
}
