



using SectionManagement.Application.Services.SectionSingleService.Query;

namespace SectionManagement.Api.Extensions;

public static class SectionSingleExtension
{
    
    public static WebApplication MapSectionSingleApi(this WebApplication app)
    {
        app.MapGet("/sectionsingle/getallsectionsinglessasync", async (ISectionSingleQueryService _sectionSingleQueryService) =>
        {
            return await _sectionSingleQueryService.GetAllSectionSinglessQuerryAsyncService();
        });

        app.MapGet("/sectionsingle/getsectionsinglebyidasync/{id:int}", async (ISectionSingleQueryService _sectionSingleQueryService, int id) =>
        {
            return await _sectionSingleQueryService.GetSectionSingleByIdQueryAsyncService(id);
        });

        app.MapGet("/sectionsingle/getsectionsinglesbysectionidasync/{id:int}", async (ISectionSingleQueryService _sectionSingleQueryService, int sectionId) =>
        {
            return await _sectionSingleQueryService.GetSectionSinglesBySectionIdService(sectionId);
        });
        return app;
    }

}
