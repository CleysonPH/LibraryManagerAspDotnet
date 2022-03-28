using LibraryManager.Core.Config;
using LibraryManager.Core.Contexts;
using LibraryManager.Core.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Config DBContext
builder.ExecuteDatasourceConfig();

// Config JsonSerializer
builder.ExecuteSerializerConfig();

// Config Dependecy Injection of Author
builder.ExecuteAuthorConfig();
// Config Dependecy Injection of Book
builder.ExecuteBookConfig();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseMiddleware<ExceptionHandlerMiddleware>();

app.Run();
