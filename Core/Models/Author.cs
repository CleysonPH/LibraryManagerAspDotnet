namespace LibraryManager.Core.Models;

public class Author : IModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Bio { get; set; }
    public ICollection<Book>? Books { get; set; }
}