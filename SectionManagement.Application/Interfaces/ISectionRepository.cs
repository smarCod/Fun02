using SectionManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionManagement.Application.Interfaces;

public interface ISectionRepository
{
    Task<IList<Section>> GetAllSectionsAsyncRep();
    Task<Section> GetSectionByIdAsyncRep(int id);
    Task<Section> PostSectionAsyncRep(Section section);
    Task<Section> UpdateSectionAsyncRep(Section section);
    Task<Section> DeleteSectionAsyncRep(int id);
}
