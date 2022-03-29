using LibraryManager.Api.Books.UseCases;
using LibraryManager.Api.Books.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManager.Api.Books.Controllers;

[ApiController]
[Route("/api/books")]
public class BookController : ControllerBase
{
    private readonly IListBookUseCase _listBookUseCase;
    private readonly ICreateBookUseCase _createBookUseCase;
    private readonly IFindBookByIdUseCase _findBookByIdUseCase;
    private readonly IUpdateBookByIdUseCase _updateBookByIdUseCase;
    private readonly IDeleteBookByIdUseCase _deleteBookByIdUseCase;

    public BookController(
        IListBookUseCase listBookUseCase,
        ICreateBookUseCase createBookUseCase,
        IFindBookByIdUseCase findBookByIdUseCase,
        IUpdateBookByIdUseCase updateBookByIdUseCase,
        IDeleteBookByIdUseCase deleteBookByIdUseCase)
    {
        _listBookUseCase = listBookUseCase;
        _createBookUseCase = createBookUseCase;
        _findBookByIdUseCase = findBookByIdUseCase;
        _updateBookByIdUseCase = updateBookByIdUseCase;
        _deleteBookByIdUseCase = deleteBookByIdUseCase;
    }

    [HttpPost]
    public ActionResult<DetailBookViewModel> Create([FromBody] CreateBookViewModel createBookViewModel)
    {
        var createdBookViewModel = _createBookUseCase.Execute(createBookViewModel);
        return CreatedAtAction(
            nameof(FindById),
            new { BookId = createdBookViewModel.Id },
            createdBookViewModel
        );
    }

    [HttpGet]
    public ActionResult<IEnumerable<DetailBookViewModel>> FindAll()
    {
        return Ok(_listBookUseCase.Execute());
    }

    [HttpGet("{bookId}")]
    public ActionResult<DetailBookViewModel> FindById([FromRoute] int bookId)
    {
        return Ok(_findBookByIdUseCase.Execute(bookId));
    }

    [HttpPut("{bookId}")]
    public ActionResult<DetailBookViewModel> UpdateById([FromRoute] int bookId, [FromBody] UpdateBookViewModel updateBookViewModel)
    {
        return Ok(_updateBookByIdUseCase.Execute(bookId, updateBookViewModel));
    }

    [HttpDelete("{bookId}")]
    public ActionResult DeleteById([FromRoute] int bookId)
    {
        _deleteBookByIdUseCase.Execute(bookId);
        return NoContent();
    }
}