// Annotations
using Microsoft.EntityFrameworkCore;

class SchoolContext : DbContext
{
    public SchoolContext()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=SchoolDbWithAnnotations;Integrated Security=True;Trust Server Certificate=True;")
            .UseValidationCheckConstraints();

    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Faculty> Faculties { get; set; }
    public DbSet<Department> Departments { get; set; }


}

