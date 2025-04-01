using LearnMiddleware.MiddleComponents;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddTransient<ExceptionHandlingClass>();
app.UseMiddleware<ExceptionHandlingClass>();
// Middleware #1
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Middleware #1: Before calling next\r\n");

    await next(context);

    await context.Response.WriteAsync("Middleware #1: After calling next\r\n");

});

// Middleware #2
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Middleware #2: Before calling next\r\n");

    //await next(context);

    await context.Response.WriteAsync("Middleware #2: After calling next\r\n");

});

// Middleware #3
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Middleware #3: Before calling next\r\n");

    await next(context);

    await context.Response.WriteAsync("Middleware #3: After calling next\r\n");

});


app.Run();
