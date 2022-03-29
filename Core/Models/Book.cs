namespace LibraryManager.Core.Models;

public class Book : IModel
{
    public int ID { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public Author Author { get; set; } = null!;
    public int AuthorID { get; set; }
}
