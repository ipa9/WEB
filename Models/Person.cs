// Models/Book.cs
using System;
using System.ComponentModel.DataAnnotations;

public class Book
{
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }

    [Range(1900, int.MaxValue, ErrorMessage = "Year of Publication must be 1900 or later.")]
    public int YearOfPublication { get; set; }

    public string AuthorName { get; set; }

    // Navigation property for Author
    public Author Author { get; set; }
}