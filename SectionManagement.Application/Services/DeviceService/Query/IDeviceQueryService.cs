
using SectionManagement.Application.Services.DeviceService.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionManagement.Application.Services.DeviceService.Query;

public interface IDeviceQueryService
{
    Task<IList<DeviceRequest>> GetAllDevicesQuerryAsyncService();
    Task<DeviceRequest> GetDeviceByIdQueryAsyncService(int id);

}
