using LibraryManager.Api.Authors.ViewModels;
using LibraryManager.Core.ViewModels;

namespace LibraryManager.Api.Books.ViewModels;

public class DetailBookViewModel : IViewModel
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public DetailAuthorViewModel Author { get; set; } = null!;
}