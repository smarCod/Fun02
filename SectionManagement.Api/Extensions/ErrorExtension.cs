



using Microsoft.AspNetCore.Diagnostics;

namespace SectionManagement.Api.Extensions;

public static class ErrorExtension
{
    public static WebApplication MapErrorApi(this WebApplication app)
    {

        app.MapGet("/error", (HttpContext context) =>
        {
            Exception? exception = context.Features.Get<IExceptionHandlerFeature>()?.Error;
            return Results.Problem(title: exception?.Message, statusCode: 400);
        });
        return app;
    }
}
