// Dtos/UpdateBookDto.cs
using System;
using System.ComponentModel.DataAnnotations;

public class UpdateBookDto
{
    [Required]
    public string Title { get; set; }

    [Required]
    [Range(1900, int.MaxValue, ErrorMessage = "Year of Publication must be 1900 or later.")]
    public int YearOfPublication { get; set; }

    [Required]
    public string AuthorName { get; set; }
}
