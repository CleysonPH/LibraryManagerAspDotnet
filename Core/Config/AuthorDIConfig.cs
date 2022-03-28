using LibraryManager.Api.Authors.Mappers;
using LibraryManager.Api.Authors.UseCases;
using LibraryManager.Core.Repositories;

namespace LibraryManager.Core.Config;

public static class AuthorDIConfig
{
    public static void ExecuteAuthorConfig(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
        builder.Services.AddScoped<IAuthorMapper, AuthorMapper>();
        builder.Services.AddScoped<ICreateAuthorUseCase, CreateAuthorUseCase>();
        builder.Services.AddScoped<IListAuthorsUseCase, ListAuthorsUseCase>();
        builder.Services.AddScoped<IFindAuthorByIdUseCase, FindAuthorByIdUseCase>();
        builder.Services.AddScoped<IDeleteAuthorByIdUseCase, DeleteAuthorByIdUseCase>();
        builder.Services.AddScoped<IUpdateAuthorByIdUseCase, UpdateAuthorByIdUseCase>();
    }
}