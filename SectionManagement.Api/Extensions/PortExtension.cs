

using Microsoft.AspNetCore.Identity;
using SectionManagement.Application.Services.PortService.Command;
using SectionManagement.Application.Services.PortService.Common;
using SectionManagement.Application.Services.PortService.Queries;

namespace SectionManagement.Api.Extensions;


public static class PortExtension
{
    public static WebApplication MapPortApi(this WebApplication app)
    {
        app.MapGet("/port/getallportsasync", async (IPortQueryService _portQueryService) =>
        {
            return Results.Ok(await _portQueryService.GetAllPortsQuerryAsyncService());
        }).RequireAuthorization("NormalUser");

        app.MapGet("/port/getportbyid/{id:int}", async (IPortQueryService _portQueryService, int id) =>
        {
            return Results.Ok(await _portQueryService.GetPortByIdQueryAsyncService(id));
        });

        app.MapPost("/port/postportasync", async (IPortCommandService _portCommandService, PortRequest portName) =>
        {
            return Results.Ok(await _portCommandService.PostPortAsyncService(portName));
        });

        app.MapPut("/port/updateportasync", async (IPortCommandService _portServiceCommand, PortRequest portName) =>
        {
            return Results.Ok(await _portServiceCommand.UpdatePortAsyncService(portName));
        });

        app.MapDelete("/port/deleteportasync/{id:int}", async (IPortCommandService _portCommandService, int id) =>
        {
            await _portCommandService.DeletePortAsyncService(id);
            return Results.Ok();
        });

        return app;
    }
}