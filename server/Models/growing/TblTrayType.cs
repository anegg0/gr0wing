using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Localhost.Models.Growing
{
  [Table("tblTrayType")]
  public partial class TblTrayType
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TrayTypeId
    {
      get;
      set;
    }

    public ICollection<TblTray> TblTrays { get; set; }
    public string TrayName
    {
      get;
      set;
    }
    public string TrayHandle
    {
      get;
      set;
    }
    public string TrayLength
    {
      get;
      set;
    }
    public string TrayWidth
    {
      get;
      set;
    }
    public string TrayHeight
    {
      get;
      set;
    }
  }
}
