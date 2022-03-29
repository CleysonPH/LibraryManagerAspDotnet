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

    public DetailBookViewModel ToDetailViewModel(Book book)
    {
        return new DetailBookViewModel
        {
            Id = book.Id,
            Title = book.Title,
            Description = book.Description,
            Author = _authorMapper.ToDetailViewModel(book.Author)
        };
    }

    public Book ToModel(CreateBookViewModel createBookViewModel)
    {
        return new Book
        {
            Title = createBookViewModel.Title,
            Description = createBookViewModel.Description,
            AuthorId = createBookViewModel.AuthorId,
            Author = _authorRepository.FindById(createBookViewModel.AuthorId)
        };
    }

    public Book ToModel(UpdateBookViewModel updateBookViewModel)
    {
        return new Book
        {
            Title = updateBookViewModel.Title,
            Description = updateBookViewModel.Description,
            AuthorId = updateBookViewModel.AuthorId,
            Author = _authorRepository.FindById(updateBookViewModel.AuthorId)
        };
    }
}