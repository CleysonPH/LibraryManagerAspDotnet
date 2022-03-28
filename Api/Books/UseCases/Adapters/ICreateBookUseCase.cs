using LibraryManager.Api.Books.ViewModels;
using LibraryManager.Core.UseCases;

namespace LibraryManager.Api.Books.UseCases;

public interface ICreateBookUseCase : IUseCase<CreateBookViewModel, DetailBookViewModel>
{ }