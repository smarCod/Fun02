using SectionManagement.Application.Interfaces;
using SectionManagement.Application.Services.PortService.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionManagement.Application.Services.PortService.Queries;

public class PortQueryService : IPortQueryService
{
    private readonly IPortRepository _portRepository;

    public PortQueryService(IPortRepository portRepository)
    {
        _portRepository = portRepository;
    }

    public async Task<IList<PortRequest>> GetAllPortsQuerryAsyncService()
    {
        var result = await _portRepository.GetAllPortsAsyncRep();
        IList<PortRequest> ports = result.Select(x => new PortRequest(x.PortId, x.Name) { }).ToList();
        return ports;
    }

    public async Task<PortRequest> GetPortByIdQueryAsyncService(int id)
    {
        var result = await _portRepository.GetPortByIdAsyncRep(id);
        PortRequest portName = new PortRequest(result.PortId, result.Name);
        return portName;
    }
}
