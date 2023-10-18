using SectionManagement.Application.Services.PortService.Common;
using SectionManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionManagement.Application.Services.PortService.Command;

public interface IPortCommandService
{
    Task<PortRequest> PostPortAsyncService(PortRequest portName);
    Task<PortRequest> UpdatePortAsyncService(PortRequest portName);
    Task<Port> DeletePortAsyncService(int id);
}
