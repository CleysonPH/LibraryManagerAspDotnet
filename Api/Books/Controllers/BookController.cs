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

    public BookController(IListBookUseCase listBookUseCase, ICreateBookUseCase createBookUseCase)
    {
        _listBookUseCase = listBookUseCase;
        _createBookUseCase = createBookUseCase;
    }

    [HttpPost]
    public DetailBookViewModel Create([FromBody] CreateBookViewModel createBookViewModel)
    {
        return _createBookUseCase.Execute(createBookViewModel);
    }

    [HttpGet]
    public ActionResult<IEnumerable<DetailBookViewModel>> FindAll()
    {
        return Ok(_listBookUseCase.Execute());
    }
}