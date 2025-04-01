
namespace LearnMiddleware.MiddleComponents
{
    public class MyCustomMiddlewareClass : IMiddleware
    {
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            throw new NotImplementedException();
        }
    }
}
