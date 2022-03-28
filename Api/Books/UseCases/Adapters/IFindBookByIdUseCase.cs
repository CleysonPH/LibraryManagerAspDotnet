using LibraryManager.Api.Books.ViewModels;
using LibraryManager.Core.UseCases;

namespace LibraryManager.Api.Books.UseCases;

public interface IFindBookByIdUseCase : IUseCase<int, DetailBookViewModel>
{ }