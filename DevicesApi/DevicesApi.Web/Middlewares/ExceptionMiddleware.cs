using System.Net;
using System.Text.Json;

namespace DevicesApi.Web.Middlewares
{
    // internal Exeception Class. used only here for the response when an error happens
    internal class ExceptionResponse
    {
        public int StatusCode { get; set; }
        public string? Message { get; set; }
        public string? StackTrace { get; set; }
    };

    // standard usage of global exception middleware
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;
        private readonly IHostEnvironment _env;

        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger, IHostEnvironment env)
        {
            _env = env;
            _logger = logger;
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception e)
            {
                if (_env.IsDevelopment())
                    _logger.LogError(e, e.Message);

                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                var response = _env.IsDevelopment() ?
                    new ExceptionResponse
                    {
                        StatusCode = context.Response.StatusCode,
                        Message = e.Message,
                        StackTrace = e.StackTrace?.ToString()
                    }
                    :
                    new ExceptionResponse
                    {
                        StatusCode = context.Response.StatusCode,
                        Message = "Internal server error"
                    };

                var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
                var json = JsonSerializer.Serialize(response, options);
                await context.Response.WriteAsync(json);
            }
        }
    }
}
