using LibraryManager.Api.Books.Mappers;
using LibraryManager.Api.Books.ViewModels;
using LibraryManager.Core.Repositories;

namespace LibraryManager.Api.Books.UseCases;

public class UpdateBookByIdUseCase : IUpdateBookByIdUseCase
{
    private readonly IBookMapper _bookMapper;
    private readonly IBookRepository _bookRepository;

    public UpdateBookByIdUseCase(IBookMapper bookMapper, IBookRepository bookRepository)
    {
        _bookMapper = bookMapper;
        _bookRepository = bookRepository;
    }

    public DetailBookViewModel Execute(int bookId, UpdateBookViewModel updateBookViewModel)
    {
        var bookToUpdate = _bookMapper.ToModel(updateBookViewModel);
        var updatedBook = _bookRepository.UpdateById(bookId, bookToUpdate);
        return _bookMapper.ToDetailViewModel(updatedBook);
    }
}