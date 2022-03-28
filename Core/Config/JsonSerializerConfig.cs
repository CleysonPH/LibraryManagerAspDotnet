using LibraryManager.Core.Policies;

namespace LibraryManager.Core.Config;

public static class JsonSerializerConfig
{
    public static void ExecuteCondfig(WebApplicationBuilder builder)
    {
        builder.Services.AddMvc().AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.PropertyNamingPolicy = new SnakeCaseNamingPolicy();
        });
    }
}