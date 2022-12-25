namespace Woidbua.Cqrs;

public abstract record DomainEvent(Guid Id) : IDomainEvent;
