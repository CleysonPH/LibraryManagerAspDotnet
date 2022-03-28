using LibraryManager.Core.Contexts;
using LibraryManager.Core.Exceptions;
using LibraryManager.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManager.Core.Repositories;

public class BookRepository : IBookRepository
{
    private readonly LibraryManagerContext _context;

    public BookRepository(LibraryManagerContext context)
    {
        _context = context;
    }

    public Book Create(Book model)
    {
        _context.Add(model);
        _context.SaveChanges();
        return model;
    }

    public void DeleteById(int id)
    {
        var book = FindById(id);
        _context.Remove(book);
        _context.SaveChanges();
    }

    public IEnumerable<Book> FindAll()
    {
        return _context.Books
            .Include(book => book.Author)
            .ToList();
    }

    public Book FindById(int id)
    {
        var book = _context.Books
            .Where(book => book.ID == id)
            .FirstOrDefault();
        return book ?? throw new BookNotFoundException();
    }

    public Book UpdateById(int id, Book model)
    {
        var book = FindById(id);
        book.Title = model.Title;
        book.Description = model.Description;
        book.Author = model.Author;
        _context.SaveChanges();
        return book;
    }
}