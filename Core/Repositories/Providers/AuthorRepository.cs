using LibraryManager.Core.Contexts;
using LibraryManager.Core.Exceptions;
using LibraryManager.Core.Models;

namespace LibraryManager.Core.Repositories;

public class AuthorRepository : IAuthorRepository
{
    private readonly LibraryManagerContext _context;

    public AuthorRepository(LibraryManagerContext context)
    {
        _context = context;
    }

    public Author Create(Author model)
    {
        _context.Add(model);
        _context.SaveChanges();
        return model;
    }

    public void DeleteById(int id)
    {
        var author = FindById(id);
        _context.Remove(author);
        _context.SaveChanges();
    }

    public IEnumerable<Author> FindAll()
    {
        return _context.Authors;
    }

    public Author FindById(int id)
    {
        var author = _context.Authors
            .Where(author => author.ID == id)
            .FirstOrDefault();
        return author ?? throw new AuthorNotFoundException();
    }

    public Author UpdateById(int id, Author model)
    {
        var author = FindById(id);
        author.Name = model.Name;
        author.Bio = model.Bio;
        _context.SaveChanges();
        return author;
    }
}