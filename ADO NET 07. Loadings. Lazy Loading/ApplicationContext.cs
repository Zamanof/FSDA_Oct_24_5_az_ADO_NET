// Read releational datas

// - Eager loading
// - Explicit loading
// + Lazy loading

using Microsoft.EntityFrameworkCore;

class ApplicationContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Group> Groups { get; set; }

    public ApplicationContext()
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseLazyLoadingProxies()
            .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=LazyLoadingDB;Integrated Security=True;Trust Server Certificate=True;");
    }
}