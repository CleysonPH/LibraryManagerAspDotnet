using System.ComponentModel.DataAnnotations;
using LibraryManager.Core.ViewModels;

namespace LibraryManager.Api.Authors.ViewModels;

public class CreateAuthorViewModel : IViewModel
{
    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string Name { get; set; } = string.Empty;
    public string? Bio { get; set; }
}