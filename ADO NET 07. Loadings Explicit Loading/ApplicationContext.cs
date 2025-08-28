// Read releational datas

// + Eager loading
// - Explicit loading
// - Lazy loading
using ADO_NET_07._Loadings_Explicit_Loading;
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
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ExplicitLoadingDB;Integrated Security=True;Trust Server Certificate=True;");
    }
}