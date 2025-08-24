﻿// Annotations
class Student
{
    public int Id { get; set; }   
    public string? FirstName { get; set; } 
    public string? LastName { get; set; }
    public int GroupId { get; set; } // Foreign Key
    public virtual Group Group { get; set; } // Navigation property
}

