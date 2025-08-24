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
            .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=SchoolDbWithFluentApi;Integrated Security=True;Trust Server Certificate=True;");

    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Faculty> Faculties { get; set; }
    public DbSet<Department> Departments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Group
        modelBuilder
            .Entity<Group>()
            .Property(x => x.GroupName)
            .IsRequired()
            .HasMaxLength(20);

        modelBuilder
            .Entity<Group>()
            .HasIndex(x => x.GroupName)
            .IsUnique()
            .HasDatabaseName("UQ_Group_GroupName");

        modelBuilder
            .Entity<Group>()
            .ToTable(x => x.HasCheckConstraint("CK_GroupRating",
            "GroupRating >= 0 AND GroupRating<=12"));

        modelBuilder
            .Entity<Group>()
            .ToTable(x => x.HasCheckConstraint("CK_CourseYear",
            "CourseYear >= 1 AND CourseYear<=4"));


        // Teacher
        modelBuilder
            .Entity<Teacher>()
            .Property(x => x.TeacherId)
            .HasColumnName("Id")
            .ValueGeneratedOnAdd();

        modelBuilder
            .Entity<Teacher>()
            .Property(x => x.FirstName)
            .IsRequired()
            .HasMaxLength(20);

        modelBuilder
            .Entity<Teacher>()
            .Property(x => x.LastName)
            .IsRequired()
            .HasMaxLength(30);

        modelBuilder
            .Entity<Teacher>()
            .Property(x => x.Email)
            .IsRequired()
            .HasColumnType("varchar")
            .HasMaxLength(50);

        modelBuilder
            .Entity<Teacher>()
            .HasIndex(x => x.Email)
            .IsUnique()
            .HasDatabaseName("UQ_Teacher_Email");

        // Student
        modelBuilder
            .Entity<Student>()
            .HasOne(s => s.Group)
            .WithMany(g => g.Students)
            .HasForeignKey(s => s.GroupId)
            .OnDelete(DeleteBehavior.NoAction)
            .HasConstraintName("FK_Groups");

        modelBuilder
           .Entity<Student>()
           .Property(x => x.FirstName)
           .IsRequired()
           .HasMaxLength(20);

        modelBuilder
          .Entity<Student>()
          .Property(x => x.LastName)
          .IsRequired()
          .HasMaxLength(30);

        modelBuilder
         .Entity<Student>()
         .Property(x => x.GroupId)
         .HasColumnName("Id_group");

    }
}

