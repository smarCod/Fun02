using SectionManagement.Application.Services.SectionService.Common;
using SectionManagement.Application.Services.SectionSingleService.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionManagement.Application.Services.SectionSingleService.Query;

public interface ISectionSingleQueryService
{
    Task<IList<SectionSingleRequest>> GetAllSectionSinglessQuerryAsyncService();
    Task<SectionSingleRequest> GetSectionSingleByIdQueryAsyncService(int id);

    Task<IList<SectionSingleRequest>> GetSectionSinglesBySectionIdService(int sectionId);
}
