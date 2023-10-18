using SectionManagement.Application.Interfaces;
using SectionManagement.Application.Services.SectionService.Common;
using SectionManagement.Application.Services.SectionSingleService.Common;
using SectionManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionManagement.Application.Services.SectionSingleService.Query;

public class SectionSingleQueryService : ISectionSingleQueryService
{
    private readonly ISectionSingleRepository _sectionSingleRepository;

    public SectionSingleQueryService(ISectionSingleRepository sectionSingleRepository)
    {
        _sectionSingleRepository = sectionSingleRepository;
    }
    public async Task<IList<SectionSingleRequest>> GetAllSectionSinglessQuerryAsyncService()
    {
        IList<SectionSingle> sectionSingles = await _sectionSingleRepository.GetAllSectionSinglesAsyncRep();
        IList<SectionSingleRequest> result = sectionSingles.Select(x => new SectionSingleRequest(x.SectionTyp, x.Description) { }).ToList();
        return result;
    }

    public Task<SectionSingleRequest> GetSectionSingleByIdQueryAsyncService(int id)
    {
        throw new NotImplementedException();
    }


    public async Task<IList<SectionSingleRequest>> GetSectionSinglesBySectionIdService(int sectionId)
    {
        IList<SectionSingle> sectionSingles = await _sectionSingleRepository.GetSectionSinglesBySectionIdRep(sectionId);
        IList<SectionSingleRequest> result = sectionSingles.Select(x => new SectionSingleRequest(x.SectionTyp, x.Description) { }).ToList();
        return result;
    }
}
