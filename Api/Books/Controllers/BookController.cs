using LibraryManager.Api.Books.UseCases;
using LibraryManager.Api.Books.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManager.Api.Books.Controllers;

[ApiController]
[Route("/api/books")]
public class BookController : ControllerBase
{
    private readonly ICreateBookUseCase _createBookUseCase;

    public BookController(ICreateBookUseCase createBookUseCase)
    {
        _createBookUseCase = createBookUseCase;
    }

    [HttpPost]
    public DetailBookViewModel Create([FromBody] CreateBookViewModel createBookViewModel)
    {
        return _createBookUseCase.Execute(createBookViewModel);
    }
}