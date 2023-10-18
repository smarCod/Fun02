


using Microsoft.EntityFrameworkCore;
using SectionManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionManagement.Infrastructure.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    //  Zum Testen ausklammern!
    //

    //protected override void OnConfiguring(DbContextOptionsBuilder options) => options
    //    .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SectionManagementDb;Trusted_Connection=True;");

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        if(!options.IsConfigured)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SectionManagementDb;Trusted_Connection=True;");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SectionSingle>()
            .HasMany(ss => ss.Devices)
            .WithOne(d => d.SectionSingle)
            .HasForeignKey(d => d.SectionSingleId);

        modelBuilder.Entity<SectionSinglePort>()
            .HasKey(ssk => new { ssk.SectionSingleId, ssk.PortId });

    }

    public DbSet<Device> PostDevice => Set<Device>();
    public DbSet<Port> PostPort => Set<Port>();
    public DbSet<Section> PostSection => Set<Section>();
    public DbSet<SectionSingle> PostSectionSingle => Set<SectionSingle>();
    public DbSet<SectionSinglePort> PostSectionSinglePort => Set<SectionSinglePort>();

    public DbSet<User> PostUser => Set<User>();

}

