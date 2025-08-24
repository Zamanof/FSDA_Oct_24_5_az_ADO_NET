// Annotations
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

class Teacher
{
    [Key] // property-ni PRIMARY KEY olaraq elan edir
    [Column("Id")] // TeacherId (EF) -> Id (DB) 
    public int TeacherId { get; set; }

    [Required]
    [MaxLength(20)]
    public string? FirstName { get; set; }

    [Required]
    [MaxLength(30)]
    public string? LastName { get; set; }

    [Required]
    [Column(TypeName ="varchar(50)")]
    public string? Email { get; set; }
    public double Salary { get; set; }
    public double Bonus { get; set; }
}

