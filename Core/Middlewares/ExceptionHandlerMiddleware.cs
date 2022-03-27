using System.Net.Mime;
using System.Text.Json;
using System.Text.Json.Serialization;
using LibraryManager.Core.Exceptions;

namespace LibraryManager.Core.Middlewares;

public class ExceptionHandlerMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionHandlerMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (ModelNotFoundException e)
        {
            await HandleModelNotFoundException(e, context.Response);
        }
    }

    private static async Task HandleModelNotFoundException(
        ModelNotFoundException exception, HttpResponse response)
    {
        var errorResponse = new ErrorResponse
        {
            Status = StatusCodes.Status404NotFound,
            Error = "Not Found",
            Message = exception.Message,
            Cause = exception.GetType().Name
        };
        response.ContentType = MediaTypeNames.Application.Json;
        response.StatusCode = errorResponse.Status;
        await response.WriteAsync(JsonSerializer.Serialize(errorResponse));
    }

    private class ErrorResponse
    {
        public int Status { get; set; }
        public string Error { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public string Cause { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}
