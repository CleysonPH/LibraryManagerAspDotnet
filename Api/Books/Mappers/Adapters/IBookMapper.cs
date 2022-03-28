using LibraryManager.Api.Books.ViewModels;
using LibraryManager.Core.Models;

namespace LibraryManager.Api.Books.Mappers;

public interface IBookMapper
{
    Book ToModel(CreateBookViewModel createBookViewModel);
    Book ToModel(UpdateBookViewModel updateBookViewModel);
    DetailBookViewModel ToDetailViewModel(Book book);
}