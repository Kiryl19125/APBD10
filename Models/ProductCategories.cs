using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APBD10.Models;

[Table("Products_Categories")]
[PrimaryKey(nameof(IdProduct), nameof(IdCategory))]
public class ProductsCategories
{
    [Column("FK_product")]
    [ForeignKey("Product")]
    public int IdProduct { get; set; }

    public Products Product { get; set; }


    [Column("FK_category")]
    [ForeignKey("Category")]
    public int IdCategory { get; set; }

    public Categories Category { get; set; }
}