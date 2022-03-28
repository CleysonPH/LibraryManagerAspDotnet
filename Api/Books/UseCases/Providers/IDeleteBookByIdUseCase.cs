using LibraryManager.Core.Repositories;

namespace LibraryManager.Api.Books.UseCases;

public class DeleteBookByIdUseCase : IDeleteBookByIdUseCase
{
    private readonly IBookRepository _bookRepository;

    public DeleteBookByIdUseCase(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public void Execute(int bookId)
    {
        _bookRepository.DeleteById(bookId);
    }
}