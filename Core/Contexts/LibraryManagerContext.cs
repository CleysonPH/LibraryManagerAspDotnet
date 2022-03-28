using LibraryManager.Core.EntityConfigs;
using LibraryManager.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManager.Core.Contexts;

public class LibraryManagerContext : DbContext
{
    private readonly IConfiguration _configuration;

    public LibraryManagerContext(DbContextOptions options, IConfiguration configuration) : base(options)
    {
        _configuration = configuration;
    }

    public DbSet<Author> Authors => Set<Author>();
    public DbSet<Book> Books => Set<Book>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(_configuration.GetConnectionString("SQLiteConnection"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration<Author>(new AuthorConfig());
        modelBuilder.ApplyConfiguration<Book>(new BookConfig());
    }
}
