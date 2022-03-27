using LibraryManager.Api.Authors.Mappers;
using LibraryManager.Api.Authors.ViewModels;
using LibraryManager.Core.Repositories;

namespace LibraryManager.Api.Authors.UseCases;

public class CreateAuthorUseCase : ICreateAuthorUseCase
{
    private readonly IAuthorMapper _authorMapper;
    private readonly IAuthorRepository _authorRepository;

    public CreateAuthorUseCase(IAuthorMapper authorMapper, IAuthorRepository authorRepository)
    {
        _authorMapper = authorMapper;
        _authorRepository = authorRepository;
    }

    public DetailAuthorViewModel Execute(CreateAuthorViewModel createAuthorViewModel)
    {
        var authorToCreate = _authorMapper.ToModel(createAuthorViewModel);
        var createdAuthor = _authorRepository.Create(authorToCreate);
        return _authorMapper.toDetailViewModel(createdAuthor);
    }
}