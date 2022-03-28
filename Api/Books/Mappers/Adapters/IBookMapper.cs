using LibraryManager.Api.Books.ViewModels;
using LibraryManager.Core.Models;

namespace LibraryManager.Api.Books.Mappers;

public interface IBookMapper
{
    Book toModel(CreateBookViewModel createBookViewModel);
    DetailBookViewModel toDetailViewModel(Book book);
}