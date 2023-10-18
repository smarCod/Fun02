using Microsoft.EntityFrameworkCore;
using SectionManagement.Application.Interfaces;
using SectionManagement.Core.Models;
using SectionManagement.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionManagement.Infrastructure.Repositories;

public class DeviceRepository : IDeviceRepository
{
    private readonly AppDbContext _appDbContext;

    public DeviceRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<IList<Device>> GetAllDeivesAsyncRep()
    {
        return await _appDbContext.PostDevice.ToListAsync();
    }

    public async Task<Device> GetDeviceByIdAsyncRep(int id)
    {
        var device = await _appDbContext.PostDevice.Where(x => x.DeviceId == id).FirstOrDefaultAsync();
        if(device == null)
        {
            throw new NotImplementedException();
        }
        return device;
    }
}
