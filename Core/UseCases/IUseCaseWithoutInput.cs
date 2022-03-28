namespace LibraryManager.Core.UseCases;

public interface IUseCaseWithoutInput<Output>
{
    Output Execute();
}