using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using LibraryManager.Core.ViewModels;

namespace LibraryManager.Api.Authors.ViewModels;

public class UpdateAuthorViewModel : IViewModel
{
    [JsonIgnore]
    public int ID { get; set; }

    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string Name { get; set; } = string.Empty;
    public string? Bio { get; set; }
}