namespace LibraryManager.Core.Exceptions;

public class BookNotFoundException : ModelNotFoundException
{
    public BookNotFoundException() : base("Book not found")
    { }

    public BookNotFoundException(string message) : base(message)
    { }
}