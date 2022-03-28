using LibraryManager.Api.Books.Mappers;
using LibraryManager.Api.Books.ViewModels;
using LibraryManager.Core.Repositories;

namespace LibraryManager.Api.Books.UseCases;

public class ListBookUseCase : IListBookUseCase
{
    private readonly IBookMapper _bookMapper;
    private readonly IBookRepository _bookRepository;

    public ListBookUseCase(IBookMapper bookMapper, IBookRepository bookRepository)
    {
        _bookMapper = bookMapper;
        _bookRepository = bookRepository;
    }

    public IEnumerable<DetailBookViewModel> Execute()
    {
        return _bookRepository.FindAll()
            .Select(_bookMapper.toDetailViewModel);
    }
}