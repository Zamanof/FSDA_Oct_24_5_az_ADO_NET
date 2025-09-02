// See https://aka.ms/new-console-template for more information

class Book
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ushort Page { get; set; }
    public float Price { get; set; }
    public List<Author> Authors { get; set; } = [];

    public override string ToString()
    {
        return $"{Name} : {Price} manat";
    }
}

