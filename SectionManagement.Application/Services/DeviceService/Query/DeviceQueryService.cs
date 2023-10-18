using SectionManagement.Application.Interfaces;
using SectionManagement.Application.Services.DeviceService.Common;
using SectionManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionManagement.Application.Services.DeviceService.Query;

public class DeviceQueryService : IDeviceQueryService
{
    private readonly IDeviceRepository _deviceRepository;

    public DeviceQueryService(IDeviceRepository deviceRepository)
    {
        _deviceRepository = deviceRepository;
    }
    public async Task<IList<DeviceRequest>> GetAllDevicesQuerryAsyncService()
    {
        IList<Device> devices = await _deviceRepository.GetAllDeivesAsyncRep();
        IList<DeviceRequest> result = devices.Select(x => new DeviceRequest(x.DeviceId, x.Name, x.SectionSingleId) { }).ToList();
        return result;
    }

    public async Task<DeviceRequest> GetDeviceByIdQueryAsyncService(int id)
    {
        var device = await _deviceRepository.GetDeviceByIdAsyncRep(id);
        DeviceRequest deviceRequest = new DeviceRequest(device.DeviceId, device.Name, device.SectionSingleId);
        return deviceRequest;
    }
}
