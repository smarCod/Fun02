using SectionManagement.Application.Services.PortService.Common;
using SectionManagement.Application.Services.SectionService.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionManagement.Application.Services.SectionService.Queries;

public interface ISectionQueryService
{
    Task<IList<SectionRequest>> GetAllSectionsQuerryAsyncService();
    Task<SectionRequest> GetSectionByIdQueryAsyncService(int id);
}
