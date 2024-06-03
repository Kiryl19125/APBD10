using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APBD10.Models;

[Table("Shopping_Carts")]
[PrimaryKey(nameof(IdAccount), nameof(IdProduct))]
public class Carts
{
    [ForeignKey("Account")]
    [Column("FK_account")]
    public int IdAccount { get; set; }

    public Accounts Account { get; set; }
    
    [ForeignKey("Product")]
    [Column("FK_product")]
    public int IdProduct { get; set; }
    
    public Products Product { get; set; }
    
    
    [Column("amount")] 
    public int Amount { get; set; }
    
}