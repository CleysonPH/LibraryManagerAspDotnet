using LibraryManager.Core.Contexts;

namespace LibraryManager.Core.Config;

public static class DatasourceConfig
{
    public static void ExecuteDatasourceConfig(this WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<LibraryManagerContext>();
    }
}