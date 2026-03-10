using Core.Domain;

namespace User.Domain;

public static class Event
{
    public record UserCreated(
    Guid UserId,
    string Name,
    string Email,
    string Password) : DomainEvent;
}