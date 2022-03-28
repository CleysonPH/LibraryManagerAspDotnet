using LibraryManager.Api.Authors.Mappers;
using LibraryManager.Api.Books.ViewModels;
using LibraryManager.Core.Models;
using LibraryManager.Core.Repositories;

namespace LibraryManager.Api.Books.Mappers;

public class BookMapper : IBookMapper
{
    private readonly IAuthorMapper _authorMapper;
    private readonly IAuthorRepository _authorRepository;

    public BookMapper(IAuthorMapper authorMapper, IAuthorRepository authorRepository)
    {
        _authorMapper = authorMapper;
        _authorRepository = authorRepository;
    }

    public DetailBookViewModel toDetailViewModel(Book book)
    {
        return new DetailBookViewModel
        {
            ID = book.ID,
            Title = book.Title,
            Description = book.Description,
            Author = _authorMapper.toDetailViewModel(book.Author)
        };
    }

    public Book toModel(CreateBookViewModel createBookViewModel)
    {
        return new Book
        {
            Title = createBookViewModel.Title,
            Description = createBookViewModel.Description,
            AuthorID = createBookViewModel.AuthorId,
            Author = _authorRepository.FindById(createBookViewModel.AuthorId)
        };
    }
}