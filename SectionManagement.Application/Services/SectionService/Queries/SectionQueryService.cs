using SectionManagement.Application.Interfaces;
using SectionManagement.Application.Services.SectionService.Common;
using SectionManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionManagement.Application.Services.SectionService.Queries;

public class SectionQueryService : ISectionQueryService
{
    private readonly ISectionRepository _sectionRepository;

    public SectionQueryService(ISectionRepository sectionRepository)
    {
        _sectionRepository = sectionRepository;
    }

    public async Task<IList<SectionRequest>> GetAllSectionsQuerryAsyncService()
    {
        IList<Section> sections = await _sectionRepository.GetAllSectionsAsyncRep();
        IList<SectionRequest> result = sections.Select(x => new SectionRequest(x.SectionId, x.Name) { }).ToList();
        return result;
    }

    public async Task<SectionRequest> GetSectionByIdQueryAsyncService(int id)
    {
        Section section = await _sectionRepository.GetSectionByIdAsyncRep(id);
        SectionRequest sectionRequest = new SectionRequest(section.SectionId, section.Name);
        return sectionRequest;
    }
}
