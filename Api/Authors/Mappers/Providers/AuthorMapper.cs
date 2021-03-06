using LibraryManager.Api.Authors.ViewModels;
using LibraryManager.Core.Models;

namespace LibraryManager.Api.Authors.Mappers;

public class AuthorMapper : IAuthorMapper
{
    public DetailAuthorViewModel ToDetailViewModel(Author author)
    {
        return new DetailAuthorViewModel
        {
            Id = author.Id,
            Name = author.Name,
            Bio = author.Bio
        };
    }

    public Author ToModel(CreateAuthorViewModel createAuthorViewModel)
    {
        return new Author
        {
            Name = createAuthorViewModel.Name,
            Bio = createAuthorViewModel.Bio
        };
    }

    public Author ToModel(UpdateAuthorViewModel updateAuthorViewModel)
    {
        return new Author
        {
            Name = updateAuthorViewModel.Name,
            Bio = updateAuthorViewModel.Bio
        };
    }
}