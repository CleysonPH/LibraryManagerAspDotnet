using System.Text.Json;
using CaseExtensions;

namespace LibraryManager.Core.Policies;

public class SnakeCaseNamingPolicy : JsonNamingPolicy
{
    public override string ConvertName(string name) => name.ToSnakeCase();
}
