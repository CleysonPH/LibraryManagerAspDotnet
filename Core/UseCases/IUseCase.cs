namespace LibraryManager.Core.UseCases;

public interface IUseCase<Input, Output>
{
    Output Execute(Input input);
}