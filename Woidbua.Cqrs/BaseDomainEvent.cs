namespace Woidbua.Cqrs;

public abstract record BaseDomainEvent(Guid Id, DateTime CreatedOnUtc) : IDomainEvent;
