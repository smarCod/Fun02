using SectionManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionManagement.Application.Interfaces;

public interface ISectionSingleRepository
{
    Task<IList<SectionSingle>> GetAllSectionSinglesAsyncRep();
    Task<SectionSingle> GetSectionSingleByIdAsyncRep(int id);
    Task<SectionSingle> PostSectionSingleAsyncRep(SectionSingle sectionSingle);
    Task<SectionSingle> UpdateSectionSingleAsyncRep(SectionSingle sectionSingle);
    Task<SectionSingle> DeleteSectionSingleAsyncRep(int id);


    Task<IList<SectionSingle>> GetSectionSinglesBySectionIdRep(int sectionId);
}
