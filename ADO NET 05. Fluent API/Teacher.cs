// Annotations
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

class Teacher
{
    public int TeacherId { get; set; }  
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public double Salary { get; set; }
    public double Bonus { get; set; }
}

