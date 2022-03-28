using LibraryManager.Core.Models;

namespace LibraryManager.Core.Repositories;

public interface IBookRepository : ICrudRepository<Book, int>
{ }