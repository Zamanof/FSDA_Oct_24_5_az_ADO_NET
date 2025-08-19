﻿namespace ADO_NET_03._Database_first;

class Author
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public override string ToString()
    {
        return $"{Id}. {FirstName} {LastName}";
    }
}
