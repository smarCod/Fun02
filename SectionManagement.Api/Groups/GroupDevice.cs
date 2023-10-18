



using Microsoft.AspNetCore.Http.HttpResults;
using SectionManagement.Application.Services.DeviceService.Common;
using SectionManagement.Application.Services.DeviceService.Query;


namespace SectionManagement.Api.Groups;

public static class GroupDevice
{
    public static RouteGroupBuilder GroupDeviceApi(this RouteGroupBuilder group)
    {
        group.MapGet("/device/message", () => "Die Device Api");
        group.MapGet("/getalldevices/v1", GetAllDevicessAsyncV1);
        group.MapGet("/getdevicebyid/{id:int}/v1", GetDeviceByIdAsyncV1);

        return group;
    }

    public static async Task<Results<Ok<IList<DeviceRequest>>, NotFound>> GetAllDevicessAsyncV1(IDeviceQueryService _deviceQueryService)
    {
        var result = await _deviceQueryService.GetAllDevicesQuerryAsyncService();
        if (result != null)
        {
            return TypedResults.Ok(result);
        }
        return TypedResults.NotFound();
    }

    public static async Task<Results<Ok<DeviceRequest>, NotFound>> GetDeviceByIdAsyncV1(IDeviceQueryService _deviceQueryService, int id)
    {
        var result = await _deviceQueryService.GetDeviceByIdQueryAsyncService(id);
        if (result != null)
        {
            return TypedResults.Ok(result);
        }
        return TypedResults.NotFound();
    }

}
