namespace LibraryManager.Core.UseCases;

public interface IUseCaseWithoutIn<Out>
{
    Out Execute();
}