using Microsoft.EntityFrameworkCore;

namespace ADO_NET_03._Database_first;

class LibraryContext: DbContext
{
    public DbSet<Lib> Libs { get; set; }
    public DbSet<Author> Authors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Library;Integrated Security=True;Trust Server Certificate=True;");
    }
}
