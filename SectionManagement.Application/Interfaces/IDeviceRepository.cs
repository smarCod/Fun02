using SectionManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionManagement.Application.Interfaces;

public interface IDeviceRepository
{
    Task<IList<Device>> GetAllDeivesAsyncRep();
    Task<Device> GetDeviceByIdAsyncRep(int id);
}
