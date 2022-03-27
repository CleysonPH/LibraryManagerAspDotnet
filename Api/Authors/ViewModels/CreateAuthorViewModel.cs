using LibraryManager.Core.ViewModels;

namespace LibraryManager.Api.Authors.ViewModels;

public class CreateAuthorViewModel : IViewModel
{
    public string Name { get; set; } = string.Empty;
    public string? Bio { get; set; }
}