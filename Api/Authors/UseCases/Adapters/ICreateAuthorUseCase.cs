using LibraryManager.Api.Authors.ViewModels;
using LibraryManager.Core.UseCases;

namespace LibraryManager.Api.Authors.UseCases;

public interface ICreateAuthorUseCase : IUseCase<CreateAuthorViewModel, DetailAuthorViewModel>
{ }