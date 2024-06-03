using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD10.Models;

[Table("Roles")] 
public class Roles
{
    [Key]
    [Column("PK_role")]
    public int IdRole { get; set; }
    
    [MaxLength(100)]
    [Column("name")]
    public string Name { get; set; }
    
    public IEnumerable<Accounts> Accounts {get; set;}
}