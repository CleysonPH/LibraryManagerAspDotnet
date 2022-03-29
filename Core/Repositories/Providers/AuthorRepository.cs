using LibraryManager.Core.Contexts;
using LibraryManager.Core.Exceptions;
using LibraryManager.Core.Models;
using Microsoft.EntityFrameworkCore;

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

    public bool ExistsById(int id)
    {
        return _context.Authors.Count(author => author.Id == id) > 0;
    }

    public IEnumerable<Author> FindAll()
    {
        return _context.Authors.ToList();
    }

    public Author FindById(int id)
    {
        var author = _context.Authors
            .Where(author => author.Id == id)
            .FirstOrDefault();
        return author ?? throw new AuthorNotFoundException();
    }

    public Author UpdateById(int id, Author model)
    {
        if (ExistsById(id))
        {
            model.Id = id;
            _context.Entry<Author>(model).State = EntityState.Modified;
            _context.SaveChanges();
            return model;
        }
        throw new AuthorNotFoundException();
    }
}