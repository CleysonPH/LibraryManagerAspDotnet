namespace LibraryManager.Core.Exceptions;

public class AuthorNotFoundException : ModelNotFoundException
{
    public AuthorNotFoundException() : base("Author not found")
    { }

    public AuthorNotFoundException(string message) : base(message)
    { }
}