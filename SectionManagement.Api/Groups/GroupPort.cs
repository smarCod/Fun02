




using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using SectionManagement.Application.Services.PortService.Common;
using SectionManagement.Application.Services.PortService.Queries;
using SectionManagement.Core.Models;
using SectionManagement.Infrastructure.Data;

namespace SectionManagement.Api.Groups;

public static class GroupPort
{
    public static RouteGroupBuilder GroupPortApi(this RouteGroupBuilder group)
    {
        group.MapGet("/port/v1/getallportsasync", GetAllPortsAsyncV1);
        group.MapGet("/port/v1/getportnyid/{id:int}", GetPortByIdAsyncV1);

        group.MapGet("/port/v1/getallportsdatabase", GetAllPortDatabse);
        return group;
    }

    public static async Task<Ok<Port[]>> GetAllPortDatabse(AppDbContext _appDbContext)
    {
        var todos = await _appDbContext.PostPort.ToArrayAsync();
        return TypedResults.Ok(todos);
    }

    public static async Task<Results<Ok<IList<PortRequest>>, NotFound>> GetAllPortsAsyncV1(IPortQueryService  _portQueryService)
    {
        var result = await _portQueryService.GetAllPortsQuerryAsyncService();
        if (result != null)
        {
            return TypedResults.Ok(result);
        }
        return TypedResults.NotFound();
    }

    public static async Task<Results<Ok<PortRequest>, NotFound>> GetPortByIdAsyncV1(IPortQueryService _portQueryService, int id)
    {
        var result = await _portQueryService.GetPortByIdQueryAsyncService(id);
        if (result != null)
        {
            return TypedResults.Ok(result);
        }
        return TypedResults.NotFound();
    }
}
