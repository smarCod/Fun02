




using SectionManagement.Application.Services.AuthenticationService.Command;
using SectionManagement.Application.Services.AuthenticationService.Common;
using SectionManagement.Application.Services.AuthenticationService.Query;
using SectionManagement.Core.Authentication;

namespace SectionManagement.Api.Extensions;

public static class AuthenticationApiExtension
{
    public static WebApplication MapAuthenticationApi(this WebApplication app)
    {
        app.MapGet("/room", () => "Willkommen");

        app.MapPost("/auth/register", (RegisterRequest request, IAuthenticationCommandService _authenticationCommandService) =>
        {
            AuthenticationResult authResult = _authenticationCommandService.Register(
                request.FirstName,
                request.LastName,
                request.Email,
                request.Password
            );

            return Results.Ok(authResult);
        });

        app.MapPost("/auth/login", (LoginRequest loginRequest, IAuthenticationQueryService _authenticationQueryService) =>
        {
            var logResult = _authenticationQueryService.Login(
                loginRequest.Email,
                loginRequest.Password
            );
            return Results.Ok(logResult);
        });

        return app;
    }
}
