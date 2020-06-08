using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Growing.Models.Growing
{
  [Table("tblSupplier")]
  public partial class TblSupplier
  {
    public string SupplierContactName
    {
      get;
      set;
    }
    public string SupplierCountry
    {
      get;
      set;
    }
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SupplierId
    {
      get;
      set;
    }
    public string SupplierPhoneNumber1
    {
      get;
      set;
    }
    public string SupplierPhoneNumber2
    {
      get;
      set;
    }
    public string SupplierState
    {
      get;
      set;
    }

    [Column("SupplierStreetAddress 1")]
    public string SupplierStreetAddress1
    {
      get;
      set;
    }

    [Column("SupplierStreetAddress 2")]
    public string SupplierStreetAddress2
    {
      get;
      set;
    }
    public string SupplierZipcode
    {
      get;
      set;
    }
  }
}
