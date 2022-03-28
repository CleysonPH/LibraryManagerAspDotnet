namespace LibraryManager.Core.UseCases;

public interface IUseCase<Input, Output>
{
    Output Execute(Input input);
}

public interface IUseCase<Input, Input2, Output>
{
    Output Execute(Input input, Input2 input2);
}