using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

using Growing.Models.Growing;

namespace Growing.Data
{
  public partial class GrowingContext : Microsoft.EntityFrameworkCore.DbContext
  {
    public GrowingContext(DbContextOptions<GrowingContext> options):base(options)
    {
    }

    public GrowingContext()
    {
    }

    partial void OnModelBuilding(ModelBuilder builder);

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Growing.Models.Growing.TblOrder>()
              .HasOne(i => i.TblCustomer)
              .WithMany(i => i.TblOrders)
              .HasForeignKey(i => i.CustomerId)
              .HasPrincipalKey(i => i.CustomerId);
        builder.Entity<Growing.Models.Growing.TblSeed>()
              .HasOne(i => i.TblSeason)
              .WithMany(i => i.TblSeeds)
              .HasForeignKey(i => i.SeasonId)
              .HasPrincipalKey(i => i.SeasonId);
        builder.Entity<Growing.Models.Growing.TblTray>()
              .HasOne(i => i.TblCustomer)
              .WithMany(i => i.TblTrays)
              .HasForeignKey(i => i.CustomerId)
              .HasPrincipalKey(i => i.CustomerId);
        builder.Entity<Growing.Models.Growing.TblTray>()
              .HasOne(i => i.TblSeed)
              .WithMany(i => i.TblTrays)
              .HasForeignKey(i => i.SeedId)
              .HasPrincipalKey(i => i.SeedId);
        builder.Entity<Growing.Models.Growing.TblTray>()
              .HasOne(i => i.TblTrayType)
              .WithMany(i => i.TblTrays)
              .HasForeignKey(i => i.TrayTypeId)
              .HasPrincipalKey(i => i.TrayTypeId);


        this.OnModelBuilding(builder);
    }


    public DbSet<Growing.Models.Growing.TblCustomer> TblCustomers
    {
      get;
      set;
    }

    public DbSet<Growing.Models.Growing.TblOrder> TblOrders
    {
      get;
      set;
    }

    public DbSet<Growing.Models.Growing.TblSeason> TblSeasons
    {
      get;
      set;
    }

    public DbSet<Growing.Models.Growing.TblSeed> TblSeeds
    {
      get;
      set;
    }

    public DbSet<Growing.Models.Growing.TblSupplier> TblSuppliers
    {
      get;
      set;
    }

    public DbSet<Growing.Models.Growing.TblTray> TblTrays
    {
      get;
      set;
    }

    public DbSet<Growing.Models.Growing.TblTrayType> TblTrayTypes
    {
      get;
      set;
    }
  }
}
