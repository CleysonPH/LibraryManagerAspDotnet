using LibraryManager.Api.Authors.Mappers;
using LibraryManager.Api.Authors.ViewModels;
using LibraryManager.Core.Repositories;

namespace LibraryManager.Api.Authors.UseCases;

public class FindAuthorByIdUseCase : IFindAuthorByIdUseCase
{
    private readonly IAuthorMapper _authorMapper;
    private readonly IAuthorRepository _authorRepository;

    public FindAuthorByIdUseCase(IAuthorMapper authorMapper, IAuthorRepository authorRepository)
    {
        _authorMapper = authorMapper;
        _authorRepository = authorRepository;
    }

    public DetailAuthorViewModel Execute(int authorId)
    {
        return _authorMapper.ToDetailViewModel(_authorRepository.FindById(authorId));
    }
}