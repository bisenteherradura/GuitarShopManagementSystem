using GuitarShopManagementSystem.Context.DbModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class OrderTable
{
    [Key]
    public int OrderId { get; set; }

    [ForeignKey("User")]
    public int UserId { get; set; }
    public virtual UserTable User { get; set; }

    [ForeignKey("Product")]
    public int ProductId { get; set; }
    public virtual InventoryTable Product { get; set; }

    public int Quantity { get; set; }
}
