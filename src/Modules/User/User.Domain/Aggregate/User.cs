using Core.Domain;
using static User.Domain.Event;

namespace User.Domain.Aggregate;

public class User : AggregateRoot
{
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }

    public static User Create(string name, string email, string password)
    {
        var id = Guid.NewGuid();
        var user = new User();
        user.RaiseEvent(new UserCreated(id, name, email, password));
        return user;
    }

    protected override void Apply(IDomainEvent domainEvent)
    {
        switch (domainEvent)
        {
            case UserCreated e:
                Id = e.UserId;
                Name = e.Name;
                Email = e.Email;
                Password = e.Password;
                break;
        }
    }
}