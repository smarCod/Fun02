using SectionManagement.Application.Services.PortService.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionManagement.Application.Services.PortService.Queries;

public interface IPortQueryService
{
    Task<IList<PortRequest>> GetAllPortsQuerryAsyncService();

    Task<PortRequest> GetPortByIdQueryAsyncService(int id);
}
