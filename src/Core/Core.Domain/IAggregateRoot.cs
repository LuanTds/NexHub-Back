namespace Core.Domain;

public interface IAggregateRoot
{
    Guid Id { get; }
    int Version { get; }
    IReadOnlyList<IDomainEvent> DomainEvents { get; }
    void ClearEvents();
    void LoadFromHistory(IEnumerable<IDomainEvent> events);
}