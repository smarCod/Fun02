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

public class PortRepository : IPortRepository
{
    private readonly AppDbContext _appDbContext;

    public PortRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<IList<Port>> GetAllPortsAsyncRep()
    {
        return await _appDbContext.PostPort.ToListAsync();
    }

    public async Task<Port> GetPortByIdAsyncRep(int id)
    {
        var result = await _appDbContext.PostPort.Where(x => x.PortId == id).FirstOrDefaultAsync();

        if (result == null)
        {
            throw new NotImplementedException();
        }
        else
            return result;
    }

    public async Task<Port> PostPortAsyncRep(Port port)
    {
        _appDbContext.PostPort.Add(port);
        await _appDbContext.SaveChangesAsync();
        //return Task.FromResult(port);
        return port;
    }

    public async Task<Port> UpdatePortAsyncRep(Port port)
    {
        await _appDbContext.SaveChangesAsync();
        return port;
    }

    public async Task<Port> DeletePortAsyncRep(int id)
    {
        var result = await _appDbContext.PostPort.Where(x => x.PortId == id).FirstOrDefaultAsync();
        if (result != null)
        {
            _appDbContext.PostPort.Remove(result);
            await _appDbContext.SaveChangesAsync();
            return result;
        }

        return new Port();
    }


}
