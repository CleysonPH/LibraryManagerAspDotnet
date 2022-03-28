using System.ComponentModel.DataAnnotations;
using LibraryManager.Core.ViewModels;

namespace LibraryManager.Api.Books.ViewModels;

public class UpdateBookViewModel : IViewModel
{
    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string Title { get; set; } = string.Empty;

    public string? Description { get; set; }

    [Range(1, int.MaxValue)]
    public int AuthorId { get; set; }
}