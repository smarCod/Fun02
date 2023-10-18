using SectionManagement.Application.Interfaces;
using SectionManagement.Application.Services.PortService.Common;
using SectionManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionManagement.Application.Services.PortService.Command;

//  Todo check in Application -> dependencyInjection!
public class PortCommandService : IPortCommandService
{
    private readonly IPortRepository _portRepository;

    public PortCommandService(IPortRepository portRepository)
    {
        _portRepository = portRepository;
    }

    public async Task<PortRequest> PostPortAsyncService(PortRequest portName)
    {
        Port port = new Port() { Name = portName.portName };
        await _portRepository.PostPortAsyncRep(port);
        return portName;
    }

    public async Task<PortRequest> UpdatePortAsyncService(PortRequest portName)
    {
        Port portToUpdate = await _portRepository.GetPortByIdAsyncRep(portName.portId);
        portToUpdate.Name = portName.portName;
        await _portRepository.UpdatePortAsyncRep(portToUpdate);
        return portName;
    }

    public async Task<Port> DeletePortAsyncService(int id)
    {
        await _portRepository.DeletePortAsyncRep(id);
        return new Port();
    }

}
