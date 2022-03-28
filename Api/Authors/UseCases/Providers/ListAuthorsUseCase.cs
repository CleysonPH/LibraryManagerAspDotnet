using LibraryManager.Api.Authors.Mappers;
using LibraryManager.Api.Authors.ViewModels;
using LibraryManager.Core.Repositories;

namespace LibraryManager.Api.Authors.UseCases;

public class ListAuthorsUseCase : IListAuthorsUseCase
{
    private readonly IAuthorMapper _authorMapper;
    private readonly IAuthorRepository _authorRepository;

    public ListAuthorsUseCase(IAuthorMapper authorMapper, IAuthorRepository authorRepository)
    {
        _authorMapper = authorMapper;
        _authorRepository = authorRepository;
    }

    public IEnumerable<DetailAuthorViewModel> Execute()
    {
        return _authorRepository.FindAll()
            .Select(_authorMapper.ToDetailViewModel);
    }
}