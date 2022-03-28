using System.Text.Json;
using LibraryManager.Core.Extensions;

namespace LibraryManager.Core.Policies;

public class SnakeCaseNamingPolicy : JsonNamingPolicy
{
    public override string ConvertName(string name) => name.ToSnakeCase();
}
