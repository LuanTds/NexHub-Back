namespace Core.Domain;

public abstract class AggregateRoot : IAggregateRoot
{
    public Guid Id { get; protected set; }
    public int Version { get; private set; } = 0;

    private readonly List<IDomainEvent> _domainEvents = new();
    public IReadOnlyList<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

    protected void RaiseEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
        Apply(domainEvent);
        Version++;
    }

    protected abstract void Apply(IDomainEvent domainEvent);

    public void ClearEvents() => _domainEvents.Clear();

    public void LoadFromHistory(IEnumerable<IDomainEvent> events)
    {
        foreach (var e in events)
        {
            Apply(e);
            Version++;
        }
    }
}