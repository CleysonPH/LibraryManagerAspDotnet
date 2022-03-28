using LibraryManager.Api.Books.Mappers;
using LibraryManager.Api.Books.ViewModels;
using LibraryManager.Core.Repositories;

namespace LibraryManager.Api.Books.UseCases;

public class FindBookByIdUseCase : IFindBookByIdUseCase
{
    private readonly IBookMapper _bookMapper;
    private readonly IBookRepository _bookRepository;

    public FindBookByIdUseCase(IBookMapper bookMapper, IBookRepository bookRepository)
    {
        _bookMapper = bookMapper;
        _bookRepository = bookRepository;
    }

    public DetailBookViewModel Execute(int bookId)
    {
        return _bookMapper.ToDetailViewModel(_bookRepository.FindById(bookId));
    }
}