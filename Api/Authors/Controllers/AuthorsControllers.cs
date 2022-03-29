using LibraryManager.Api.Authors.UseCases;
using LibraryManager.Api.Authors.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManager.Api.Authors.Controllers;

[ApiController]
[Route("/api/authors")]
public class AuthorsControllers : ControllerBase
{
    private readonly IListAuthorsUseCase _listAuthorsUseCase;
    private readonly ICreateAuthorUseCase _createAuthorUseCase;
    private readonly IFindAuthorByIdUseCase _findAuthorByIdUseCase;
    private readonly IDeleteAuthorByIdUseCase _deleteAuthorByIdUseCase;
    private readonly IUpdateAuthorByIdUseCase _updateAuthorByIdUseCase;

    public AuthorsControllers(
        IListAuthorsUseCase listAuthorsUseCase,
        ICreateAuthorUseCase createAuthorUseCase,
        IFindAuthorByIdUseCase findAuthorByIdUseCase,
        IDeleteAuthorByIdUseCase deleteAuthorByIdUseCase,
        IUpdateAuthorByIdUseCase updateAuthorByIdUseCase)
    {
        _listAuthorsUseCase = listAuthorsUseCase;
        _createAuthorUseCase = createAuthorUseCase;
        _findAuthorByIdUseCase = findAuthorByIdUseCase;
        _deleteAuthorByIdUseCase = deleteAuthorByIdUseCase;
        _updateAuthorByIdUseCase = updateAuthorByIdUseCase;
    }

    [HttpGet]
    public ActionResult<IEnumerable<DetailAuthorViewModel>> FindAll()
    {
        return Ok(_listAuthorsUseCase.Execute());
    }

    [HttpPost]
    public ActionResult<DetailAuthorViewModel> Create(
        [FromBody] CreateAuthorViewModel createAuthorViewModel)
    {
        var createdAuthorViewModel = _createAuthorUseCase.Execute(createAuthorViewModel);
        return CreatedAtAction(
            nameof(FindById),
            new { AuthorId = createdAuthorViewModel.Id },
            createdAuthorViewModel
        );
    }

    [HttpGet("{authorId}")]
    public ActionResult<DetailAuthorViewModel> FindById([FromRoute] int authorId)
    {
        return _findAuthorByIdUseCase.Execute(authorId);
    }

    [HttpDelete("{authorId}")]
    public ActionResult DeleteById([FromRoute] int authorId)
    {
        _deleteAuthorByIdUseCase.Execute(authorId);
        return NoContent();
    }

    [HttpPut("{authorId}")]
    public ActionResult<DetailAuthorViewModel> UpdateById(
        [FromRoute] int authorId, [FromBody] UpdateAuthorViewModel updateAuthorViewModel)
    {
        return _updateAuthorByIdUseCase.Execute(authorId, updateAuthorViewModel);
    }
}
