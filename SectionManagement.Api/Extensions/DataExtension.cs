




using SectionManagement.Core.Models;
using SectionManagement.Infrastructure.Data;

namespace SectionManagement.Api.Extensions;

public static class DataExtension
{
    public static WebApplication MapAddDataApi(this WebApplication app)
    {
        //app.MapPost("/data/01/section", (AppDbContext _appDbContext) =>
        //{

        //    _appDbContext.PostSection.AddRange(
        //        new Section { Name = "Section 1" },
        //        new Section { Name = "Section 2" },
        //        new Section { Name = "Section 3" }
        //    );
        //    _appDbContext.SaveChanges();

        //    _appDbContext.PostSectionSingle.AddRange(
        //        new SectionSingle
        //        {
        //            SectionTyp = SectionTyp.Corridor,
        //            Name = "SectionSingle 1",
        //            Size = 23,
        //            Description = "Description 1",
        //            Section = _appDbContext.PostSection.Where(x => x.SectionId == 1).FirstOrDefault()
        //        },
        //        new SectionSingle
        //        {
        //            SectionTyp = SectionTyp.Corridor,
        //            Name = "SectionSingle 2",
        //            Size = 52,
        //            Description = "Description 2",
        //            Section = _appDbContext.PostSection.Where(x => x.SectionId == 1).FirstOrDefault()
        //        },
        //        new SectionSingle
        //        {
        //            SectionTyp = SectionTyp.Corridor,
        //            Name = "SectionSingle 3",
        //            Size = 093,
        //            Description = "Description 3",
        //            Section = _appDbContext.PostSection.Where(x => x.SectionId == 2).FirstOrDefault()
        //        },
        //        new SectionSingle
        //        {
        //            SectionTyp = SectionTyp.Corridor,
        //            Name = "SectionSingle 4",
        //            Size = 12,
        //            Description = "Description 4",
        //            Section = _appDbContext.PostSection.Where(x => x.SectionId == 3).FirstOrDefault()
        //        });

        //    _appDbContext.SaveChanges();

        //    return Results.Ok();
        //});
        //app.MapPost("/data/02/devices", (AppDbContext _appDbContext) =>
        //{

        //    Device[] device = new Device[]
        //    {
        //                   new Device { Name = "Device 1",
        //                       SectionSingle = _appDbContext.PostSectionSingle.Where(x => x.SectionSingleId == 4).FirstOrDefault()},
        //                   new Device { Name = "Device 2",
        //                       SectionSingle = _appDbContext.PostSectionSingle.Where(x => x.SectionSingleId == 2).FirstOrDefault()},
        //                   new Device { Name = "Device 3",
        //                       SectionSingle = _appDbContext.PostSectionSingle.Where(x => x.SectionSingleId == 3).FirstOrDefault()},
        //                   new Device { Name = "Device 4",
        //                       SectionSingle = _appDbContext.PostSectionSingle.Where(x => x.SectionSingleId == 2).FirstOrDefault()},
        //                   new Device { Name = "Device 5",
        //                       SectionSingle = _appDbContext.PostSectionSingle.Where(x => x.SectionSingleId == 1).FirstOrDefault()},
        //                   new Device { Name = "Device 6",
        //                       SectionSingle = _appDbContext.PostSectionSingle.Where(x => x.SectionSingleId == 3).FirstOrDefault()},
        //                   new Device { Name = "Device 7",
        //                       SectionSingle = _appDbContext.PostSectionSingle.Where(x => x.SectionSingleId == 1).FirstOrDefault()},
        //                   new Device { Name = "Device 8",
        //                       SectionSingle = _appDbContext.PostSectionSingle.Where(x => x.SectionSingleId == 2).FirstOrDefault()}
        //    };
        //    _appDbContext.AddRange(device);
        //    _appDbContext.SaveChanges();

        //    return Results.Ok();
        //});

        //app.MapPost("/data/03/ports", (AppDbContext _appDbContext) =>
        //{
        //    Port[] ports = new Port[]
        //    {
        //                   new Port { Name = "BF24" },
        //                   new Port { Name = "43CF" },
        //                   new Port { Name = "1F8B" },
        //                   new Port { Name = "DCB2" },
        //                   new Port { Name = "AF90" }
        //    };
        //    _appDbContext.AddRange(ports);

        //    _appDbContext.AddRange(
        //        new SectionSinglePort
        //        {
        //            SectionSingle = _appDbContext.PostSectionSingle.Where(x => x.SectionSingleId == 1).FirstOrDefault(),
        //            Port = ports[1]
        //        },
        //        new SectionSinglePort
        //        {
        //            SectionSingle = _appDbContext.PostSectionSingle.Where(x => x.SectionSingleId == 4).FirstOrDefault(),
        //            Port = ports[2]
        //        },
        //        new SectionSinglePort
        //        {
        //            SectionSingle = _appDbContext.PostSectionSingle.Where(x => x.SectionSingleId == 3).FirstOrDefault(),
        //            Port = ports[3]
        //        },
        //        new SectionSinglePort
        //        {
        //            SectionSingle = _appDbContext.PostSectionSingle.Where(x => x.SectionSingleId == 1).FirstOrDefault(),
        //            Port = ports[4]
        //        },
        //        new SectionSinglePort
        //        {
        //            SectionSingle = _appDbContext.PostSectionSingle.Where(x => x.SectionSingleId == 2).FirstOrDefault(),
        //            Port = ports[0]
        //        },
        //        new SectionSinglePort
        //        {
        //            SectionSingle = _appDbContext.PostSectionSingle.Where(x => x.SectionSingleId == 4).FirstOrDefault(),
        //            Port = ports[1]
        //        },
        //        new SectionSinglePort
        //        {
        //            SectionSingle = _appDbContext.PostSectionSingle.Where(x => x.SectionSingleId == 2).FirstOrDefault(),
        //            Port = ports[2]
        //        },
        //        new SectionSinglePort
        //        {
        //            SectionSingle = _appDbContext.PostSectionSingle.Where(x => x.SectionSingleId == 2).FirstOrDefault(),
        //            Port = ports[3]
        //        });

        //    _appDbContext.SaveChanges();
        //});

        return app;
    }
}
