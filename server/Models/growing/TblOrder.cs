using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Growing.Models.Growing
{
  [Table("tblOrder")]
  public partial class TblOrder
  {
    public int? CustomerId
    {
      get;
      set;
    }
    public TblCustomer TblCustomer { get; set; }
    public bool OrderDelivered
    {
      get;
      set;
    }
    public DateTime OrderDeliveryDate
    {
      get;
      set;
    }
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int OrderId
    {
      get;
      set;
    }
    public int OrderSequence
    {
      get;
      set;
    }
  }
}
