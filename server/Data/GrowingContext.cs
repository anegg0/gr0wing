using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

using Localhost.Models.Growing;

namespace Localhost.Data
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

        builder.Entity<Localhost.Models.Growing.TblOrder>()
              .HasOne(i => i.TblCustomer)
              .WithMany(i => i.TblOrders)
              .HasForeignKey(i => i.CustomerId)
              .HasPrincipalKey(i => i.CustomerId);
        builder.Entity<Localhost.Models.Growing.TblSeed>()
              .HasOne(i => i.TblSeason)
              .WithMany(i => i.TblSeeds)
              .HasForeignKey(i => i.SeasonId)
              .HasPrincipalKey(i => i.SeasonId);
        builder.Entity<Localhost.Models.Growing.TblTray>()
              .HasOne(i => i.TblTrayType)
              .WithMany(i => i.TblTrays)
              .HasForeignKey(i => i.TrayTypeId)
              .HasPrincipalKey(i => i.TrayTypeId);
        builder.Entity<Localhost.Models.Growing.TblTray>()
              .HasOne(i => i.TblSeed)
              .WithMany(i => i.TblTrays)
              .HasForeignKey(i => i.SeedId)
              .HasPrincipalKey(i => i.SeedId);
        builder.Entity<Localhost.Models.Growing.TblTray>()
              .HasOne(i => i.TblCustomer)
              .WithMany(i => i.TblTrays)
              .HasForeignKey(i => i.CustomerId)
              .HasPrincipalKey(i => i.CustomerId);


        this.OnModelBuilding(builder);
    }


    public DbSet<Localhost.Models.Growing.TblCustomer> TblCustomers
    {
      get;
      set;
    }

    public DbSet<Localhost.Models.Growing.TblOrder> TblOrders
    {
      get;
      set;
    }

    public DbSet<Localhost.Models.Growing.TblSeason> TblSeasons
    {
      get;
      set;
    }

    public DbSet<Localhost.Models.Growing.TblSeed> TblSeeds
    {
      get;
      set;
    }

    public DbSet<Localhost.Models.Growing.TblSupplier> TblSuppliers
    {
      get;
      set;
    }

    public DbSet<Localhost.Models.Growing.TblTray> TblTrays
    {
      get;
      set;
    }

    public DbSet<Localhost.Models.Growing.TblTrayType> TblTrayTypes
    {
      get;
      set;
    }
  }
}
