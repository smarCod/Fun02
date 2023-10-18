using Microsoft.EntityFrameworkCore;
using SectionManagement.Application.Interfaces;
using SectionManagement.Core.Models;
using SectionManagement.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionManagement.Infrastructure.Repositories;

public class SectionRepository : ISectionRepository
{
    private readonly AppDbContext _appDbContext;

    public SectionRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    public async Task<IList<Section>> GetAllSectionsAsyncRep()
    {
        return await _appDbContext.PostSection.ToListAsync();
    }

    public async Task<Section> GetSectionByIdAsyncRep(int id)
    {
        var result = await _appDbContext.PostSection.Where(x => x.SectionId == id).FirstOrDefaultAsync();
        if(result == null)
            throw new NotImplementedException();
        return result;
    }

    public async Task<Section> PostSectionAsyncRep(Section section)
    {
        await _appDbContext.PostSection.AddAsync(section);
        await _appDbContext.SaveChangesAsync();
        return section;
    }

    public async Task<Section> UpdateSectionAsyncRep(Section section)
    {
        await _appDbContext.SaveChangesAsync();
        return section;
    }

    public Task<Section> DeleteSectionAsyncRep(int id)
    {
        throw new NotImplementedException();
    }
}
