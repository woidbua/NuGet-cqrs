namespace Woidbua.Cqrs;

public abstract record DomainEvent(Guid Id) : BaseDomainEvent(Id, DateTime.UtcNow);