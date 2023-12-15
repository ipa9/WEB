// Data/BookstoreDbContext.cs
using Microsoft.EntityFrameworkCore;

public class BookstoreDbContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }

    public BookstoreDbContext(DbContextOptions<BookstoreDbContext> options)
        : base(options)
    {
    }
}
