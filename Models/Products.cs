using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD10.Models;

[Table("Products")]
public class Products
{
    [Key]
    [Column("PK_product")]
    public int PkProducts{ get; set;}
    
    [MaxLength(100)]
    [Column("name")]
    public string Name { get; set;}
    
    [Range(0,5.2,ErrorMessage = "Value must be between 0 and 5.2")]
    [Column("weight")]
    public decimal Weight { get; set; }
    
    [Range(0,5.2,ErrorMessage = "Value must be between 0 and 5.2")]
    [Column("width")]
    public decimal Width { get; set; }
    
    [Range(0,5.2,ErrorMessage = "Value must be between 0 and 5.2")]
    [Column("height")]
    public decimal Height { get; set; }
    
    [Range(0,5.2,ErrorMessage = "Value must be between 0 and 5.2")]
    [Column("depth")]
    public decimal  Depth { get; set; }
    
    public IEnumerable<Carts> Carts {get; set;}
    public IEnumerable<ProductsCategories> ProductsCategories { get; set; }
}