using LibraryManager.Api.Books.Mappers;
using LibraryManager.Api.Books.UseCases;
using LibraryManager.Core.Repositories;

namespace LibraryManager.Core.Config;

public static class BookDIConfig
{
    public static void ExecuteBookConfig(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IBookRepository, BookRepository>();
        builder.Services.AddScoped<IBookMapper, BookMapper>();
        builder.Services.AddScoped<ICreateBookUseCase, CreateBookUseCase>();
    }
}