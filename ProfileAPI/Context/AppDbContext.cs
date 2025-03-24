using Microsoft.EntityFrameworkCore;
using ProfileAPI.Entity;

namespace ProfileAPI.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Person> People { get; set; }
}

