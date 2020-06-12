using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Localhost.Models.Growing
{
  [Table("tblTray")]
  public partial class TblTray
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TrayId
    {
      get;
      set;
    }
    public int? TrayTypeId
    {
      get;
      set;
    }
    public TblTrayType TblTrayType { get; set; }
    public int? SeedId
    {
      get;
      set;
    }
    public TblSeed TblSeed { get; set; }
    public int? CustomerId
    {
      get;
      set;
    }
    public TblCustomer TblCustomer { get; set; }
    public int TraySequenceNumber
    {
      get;
      set;
    }
    public DateTime TraySowingDate
    {
      get;
      set;
    }
    public DateTime TrayUpdateDate
    {
      get;
      set;
    }
    public DateTime? ExpiryDate
    {
      get;
      set;
    }
    public string Status
    {
      get;
      set;
    }
  }
}
