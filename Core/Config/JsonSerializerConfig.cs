using LibraryManager.Core.Policies;

namespace LibraryManager.Core.Config;

public static class JsonSerializerConfig
{
    public static void ExecuteConfig(WebApplicationBuilder builder)
    {
        builder.Services.AddMvc().AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.PropertyNamingPolicy = new SnakeCaseNamingPolicy();
        });
    }
}