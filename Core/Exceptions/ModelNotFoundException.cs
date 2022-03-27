namespace LibraryManager.Core.Exceptions;

public class ModelNotFoundException : SystemException
{
    public ModelNotFoundException(string message) : base(message)
    { }
}