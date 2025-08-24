// Annotations
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

class Student
{
    public int Id { get; set; }
    
    [Required]
    [MaxLength(20)]
    public string? FirstName { get; set; }
    
    [Required]
    [MaxLength(30)]
    public string? LastName { get; set; }

    [ForeignKey("Group")]
    [Column("Id_Group")]
    public int GroupId { get; set; } // Foreign Key

    public virtual Group Group { get; set; } // Navigation property
}

