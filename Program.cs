using LinqApplications_LinqJoin;

List<Author> authors = new List<Author>()
{
    new Author
    {
        AuthorId = 1,
        Name = "Fyodor Mihayloviç Dostoyevski"
    },

    new Author
    {
        AuthorId = 2,
        Name = "Nikolay Vasilyeviç Gogol"
    },

        new Author
    {
        AuthorId = 3,
        Name = "William Shakespeare"
    },
};

List<Book> books = new List<Book>()
{
    new Book
    {
        BookId = 1,
        Title = "Yeraltından Notlar",
        AuthorId = 1

    },

    new Book
    {
        BookId = 2,
        Title = "Bir Delinin Hatıra Defteri",
        AuthorId = 2
    },

    new Book
    {
        BookId = 3,
        Title = "Fırtına",
        AuthorId = 3
    },

     new Book
    {
        BookId = 4,
        Title = "Bir Yaz Gecesi Rüyası",
        AuthorId = 3
    }
};

var query = from author in authors join @book in books on @author.AuthorId equals @book.AuthorId select new
            {
                BookName = book.Title,
                AuthorName = author.Name
            };

foreach (var item in query)
{
    Console.WriteLine(item.BookName + " - " + item.AuthorName);
}


