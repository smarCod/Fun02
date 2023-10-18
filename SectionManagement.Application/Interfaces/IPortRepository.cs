using SectionManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionManagement.Application.Interfaces;

public interface IPortRepository
{
    Task<IList<Port>> GetAllPortsAsyncRep();
    Task<Port> GetPortByIdAsyncRep(int id);
    Task<Port> PostPortAsyncRep(Port port);
    Task<Port> UpdatePortAsyncRep(Port port);
    Task<Port> DeletePortAsyncRep(int id);
}
