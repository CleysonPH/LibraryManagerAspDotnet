namespace LibraryManager.Core.UseCases;

public interface IUseCaseWithoutOut<In>
{
    void Execute(In i);
}