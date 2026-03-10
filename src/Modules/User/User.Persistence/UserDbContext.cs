using Microsoft.EntityFrameworkCore;

using DomainUser = User.Domain.Aggregate;

namespace User.Persistence;

public class UserDbContext : DbContext

{

    public UserDbContext(DbContextOptions<UserDbContext> options)

        : base(options) { }

    public DbSet<DomainUser> Users => Set<DomainUser>();

}