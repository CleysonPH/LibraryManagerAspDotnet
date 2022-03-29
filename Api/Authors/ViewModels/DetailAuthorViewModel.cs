using LibraryManager.Core.ViewModels;

namespace LibraryManager.Api.Authors.ViewModels;

public class DetailAuthorViewModel : IViewModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Bio { get; set; }
}