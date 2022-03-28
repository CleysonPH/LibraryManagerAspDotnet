using LibraryManager.Api.Authors.ViewModels;
using LibraryManager.Core.Models;

namespace LibraryManager.Api.Authors.Mappers;

public interface IAuthorMapper
{
    Author ToModel(CreateAuthorViewModel createAuthorViewModel);
    Author ToModel(UpdateAuthorViewModel updateAuthorViewModel);
    DetailAuthorViewModel toDetailViewModel(Author author);
}