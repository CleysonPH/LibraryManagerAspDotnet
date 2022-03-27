namespace LibraryManager.Core.UseCases;

public interface IUseCase<In, Out>
{
    Out Execute(In i);
}