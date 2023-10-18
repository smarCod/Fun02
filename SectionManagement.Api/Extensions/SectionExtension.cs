



using SectionManagement.Application.Services.SectionService.Queries;

namespace SectionManagement.Api.Extensions;

public static class SectionExtension
{
    
    public static WebApplication MapSectionApi(this WebApplication app)
    {
        app.MapGet("/section/getallsectionsasync", async (ISectionQueryService _sectionQueryService) =>
        {
            return await _sectionQueryService.GetAllSectionsQuerryAsyncService();
        });

        app.MapGet("/section/getsectionbyidasync/{id:int}", async (ISectionQueryService _sectionQueryService, int id) =>
        {
            return await _sectionQueryService.GetSectionByIdQueryAsyncService(id);
        });
        return app;
    }

}
