namespace LibraryManager.Core.UseCases;

public interface IUseCaseWithoutOutput<Input>
{
    void Execute(Input input);
}