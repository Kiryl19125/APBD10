using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD10.Models;

[Table("Categories")]
public class Categories
{
    [Key] 
    [Column("PK_category")]
    public int IdCategories { get; set; }

    [Column("name")]
    public string Name { get; set; }
    
    public IEnumerable<ProductsCategories> ProductsCategories { get; set; }

}