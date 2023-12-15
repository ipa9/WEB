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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure relationships, constraints, etc.
        modelBuilder.Entity<Book>()
            .HasOne(b => b.Author)
            .WithMany(a => a.Books)
            .HasForeignKey(b => b.AuthorId)
            .IsRequired(false) // If you want the relationship to be optional
            .OnDelete(DeleteBehavior.SetNull); // If you want to set null on delete
    }
}
