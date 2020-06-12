using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Localhost.Models.Growing
{
  [Table("tblCustomer")]
  public partial class TblCustomer
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CustomerId
    {
      get;
      set;
    }

    public ICollection<TblOrder> TblOrders { get; set; }
    public ICollection<TblTray> TblTrays { get; set; }
    public string CustomerName
    {
      get;
      set;
    }
    public string CustomerContactName
    {
      get;
      set;
    }

    [Column("CustomerStreetAddress 1")]
    public string CustomerStreetAddress1
    {
      get;
      set;
    }

    [Column("CustomerStreetAddress 2")]
    public string CustomerStreetAddress2
    {
      get;
      set;
    }
    public string CustomerZipcode
    {
      get;
      set;
    }
    public string CustomerState
    {
      get;
      set;
    }
    public string CustomerCountry
    {
      get;
      set;
    }
    public string CustomerPhoneNumber1
    {
      get;
      set;
    }
    public string CustomerPhoneNumber2
    {
      get;
      set;
    }
  }
}
