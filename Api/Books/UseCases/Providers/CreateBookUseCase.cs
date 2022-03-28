using LibraryManager.Api.Books.Mappers;
using LibraryManager.Api.Books.ViewModels;
using LibraryManager.Core.Repositories;

namespace LibraryManager.Api.Books.UseCases;

public class CreateBookUseCase : ICreateBookUseCase
{
    private readonly IBookMapper _bookMapper;
    private readonly IBookRepository _bookRepository;

    public CreateBookUseCase(IBookMapper bookMapper, IBookRepository bookRepository)
    {
        _bookMapper = bookMapper;
        _bookRepository = bookRepository;
    }

    public DetailBookViewModel Execute(CreateBookViewModel createBookViewModel)
    {
        var bookToCreate = _bookMapper.ToModel(createBookViewModel);
        var createdBook = _bookRepository.Create(bookToCreate);
        return _bookMapper.ToDetailViewModel(createdBook);
    }
}