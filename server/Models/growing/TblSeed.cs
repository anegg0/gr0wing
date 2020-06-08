using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Growing.Models.Growing
{
  [Table("tblSeed")]
  public partial class TblSeed
  {
    public string CurrentDTM
    {
      get;
      set;
    }
    public string DTM1
    {
      get;
      set;
    }
    public string DTM2
    {
      get;
      set;
    }
    public string DTM3
    {
      get;
      set;
    }
    public string DTM4
    {
      get;
      set;
    }
    public int SeasonId
    {
      get;
      set;
    }
    public TblSeason TblSeason { get; set; }
    public string SeedHandle
    {
      get;
      set;
    }
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SeedId
    {
      get;
      set;
    }

    public ICollection<TblTray> TblTrays { get; set; }
    public string SeedingRate
    {
      get;
      set;
    }
    public string SeedLifetime
    {
      get;
      set;
    }
    public string SeedName
    {
      get;
      set;
    }
  }
}
