namespace LibraryManager.Core.Models;

public class Author : IModel
{
    public int ID { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Bio { get; set; }
}