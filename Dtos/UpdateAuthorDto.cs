// Dtos/UpdateAuthorDto.cs
using System.ComponentModel.DataAnnotations;

public class UpdateAuthorDto
{
    [Required]
    public string Name { get; set; }
}
