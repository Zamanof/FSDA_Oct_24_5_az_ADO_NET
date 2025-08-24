// // Code First -> Many To Many


using (BookContext db = new())
{
    List<Book> books = [
        new Book { Name="46 benovshe", Page = 150, Price=25.6f},
        new Book { Name="Novellalar", Page = 350, Price=35.69f},
    ];
    Author author = new()
    {
        FirstName = "Salam",
        LastName = "Qedirzade",
        Books = books
    };

    Book book = new()
    {
        Name = "The C programming language",
        Page = 212,
        Price = 45.77f,
        Authors = [
            new Author { FirstName= "Dennis", LastName="Ritchie"},
            new Author { FirstName= "Brian", LastName="Kernighan"}
        ]
    };

    db.Authors.Add(author);
    db.Books.Add(book);

    db.SaveChanges();

}