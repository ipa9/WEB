// Mappers/Mapper.cs
using CrudAppTutorial.Dtos;
using CrudAppTutorial.Models;

public class Mapper
{
    public Book DtoToBook(CreateBookDto bookDto)
    {
        // Perform mapping logic here
        return new Book
        {
            Title = bookDto.Title,
            YearOfPublication = bookDto.YearOfPublication,
            AuthorName = bookDto.AuthorName
        };
    }

    public Book DtoToBook(UpdateBookDto bookDto)
    {
        // Perform mapping logic here
        return new Book
        {
            Title = bookDto.Title,
            YearOfPublication = bookDto.YearOfPublication,
            AuthorName = bookDto.AuthorName
        };
    }

    public Author DtoToAuthor(CreateAuthorDto authorDto)
    {
        // Perform mapping logic here
        return new Author
        {
            Name = authorDto.Name
        };
    }

    public Author DtoToAuthor(UpdateAuthorDto authorDto)
    {
        // Perform mapping logic here
        return new Author
        {
            Name = authorDto.Name
        };
    }
}
