using Microsoft.EntityFrameworkCore;
using SectionManagement.Application.Interfaces;
using SectionManagement.Core.Models;
using SectionManagement.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionManagement.Infrastructure.Repositories;

public class SectionSingleRepository : ISectionSingleRepository
{
    private readonly AppDbContext _appDbContext;

    public SectionSingleRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<IList<SectionSingle>> GetAllSectionSinglesAsyncRep()
    {
        return await _appDbContext.PostSectionSingle.ToListAsync();
    }

    public async Task<SectionSingle> GetSectionSingleByIdAsyncRep(int id)
    {
        var result = await _appDbContext.PostSectionSingle.Where(x => x.SectionSingleId == id).FirstOrDefaultAsync();
        if(result == null)
        {
            throw new NotImplementedException();
        }
        return result;
    }

    public Task<SectionSingle> PostSectionSingleAsyncRep(SectionSingle sectionSingle)
    {
        throw new NotImplementedException();
    }

    public Task<SectionSingle> UpdateSectionSingleAsyncRep(SectionSingle sectionSingle)
    {
        throw new NotImplementedException();
    }

    public Task<SectionSingle> DeleteSectionSingleAsyncRep(int id)
    {
        throw new NotImplementedException();
    }


    public async Task<IList<SectionSingle>> GetSectionSinglesBySectionIdRep(int sectionId)
    {
        return await _appDbContext.PostSectionSingle.Where(x => x.SectionId == sectionId).ToListAsync();
    }
}
