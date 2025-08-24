// // Code First -> Many To Many

class Book
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ushort Page { get; set; }
    public float Price { get; set; }
    public List<Author> Authors { get; set; } = [];
}
