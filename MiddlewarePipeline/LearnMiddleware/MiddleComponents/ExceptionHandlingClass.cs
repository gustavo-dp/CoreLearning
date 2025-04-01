
namespace LearnMiddleware.MiddleComponents
{
    public class ExceptionHandlingClass : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }catch (Exception ex)
            {
                context.Response.ContentType = "text/html";
                context.Response.StatusCode = 500; // Código de erro interno do servidor
                await context.Response.WriteAsync($"Erro interno: {ex.Message}");

            }

        }
           
    }
}
