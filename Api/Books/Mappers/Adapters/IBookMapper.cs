using LibraryManager.Api.Books.ViewModels;
using LibraryManager.Core.Models;

namespace LibraryManager.Api.Books.Mappers;

public interface IBookMapper
{
    Book ToModel(CreateBookViewModel createBookViewModel);
    DetailBookViewModel ToDetailViewModel(Book book);
}