using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Growing.Models.Growing
{
  [Table("tblSeason")]
  public partial class TblSeason
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SeasonId
    {
      get;
      set;
    }

    public ICollection<TblSeed> TblSeeds { get; set; }
    public string SeasonName
    {
      get;
      set;
    }
  }
}
