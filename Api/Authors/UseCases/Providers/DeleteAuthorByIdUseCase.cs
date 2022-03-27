using LibraryManager.Core.Repositories;

namespace LibraryManager.Api.Authors.UseCases;

public class DeleteAuthorByIdUseCase : IDeleteAuthorByIdUseCase
{
    private readonly IAuthorRepository _authorRepository;

    public DeleteAuthorByIdUseCase(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }

    public void Execute(int authorId)
    {
        _authorRepository.DeleteById(authorId);
    }
}