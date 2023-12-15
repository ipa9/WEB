// Dtos/CreateAuthorDto.cs
using System.ComponentModel.DataAnnotations;

public class CreateAuthorDto
{
    [Required]
    public string Name { get; set; }
}
