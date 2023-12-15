// Models/Author.cs
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Author
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    // Navigation property for Books
    public List<Book> Books { get; set; }
}