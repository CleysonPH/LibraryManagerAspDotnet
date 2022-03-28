using LibraryManager.Api.Authors.Mappers;
using LibraryManager.Api.Authors.ViewModels;
using LibraryManager.Core.Repositories;

namespace LibraryManager.Api.Authors.UseCases;

public class UpdateAuthorByIdUseCase : IUpdateAuthorByIdUseCase
{
    private readonly IAuthorMapper _authorMapper;
    private readonly IAuthorRepository _authorRepository;

    public UpdateAuthorByIdUseCase(IAuthorMapper authorMapper, IAuthorRepository authorRepository)
    {
        _authorMapper = authorMapper;
        _authorRepository = authorRepository;
    }

    public DetailAuthorViewModel Execute(int authorId, UpdateAuthorViewModel updateAuthorViewModel)
    {
        var authorToUpdate = _authorMapper.ToModel(updateAuthorViewModel);
        var updatedAuthor = _authorRepository.UpdateById(authorId, authorToUpdate);
        return _authorMapper.toDetailViewModel(updatedAuthor);
    }
}