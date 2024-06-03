using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD10.Models;

[Table("Accounts")]
public class Accounts
{
    [Key]
    [Column("PK_account")]
    public int IdAccount { get; set; }
    
    [Column("FK_role")]
    [ForeignKey("Role")]
    public int IdRole { get; set; }

    public Roles Role { get; set; }

    [MaxLength(50)]
    [Column("first_name")]
    public string FirstName { get; set; }
    
    [MaxLength(50)]
    [Column("last_name")]
    public string SecondName { get; set; }
    
    [MaxLength(80)]
    [Column("email")]
    public string Email { get; set; }
    
    [MaxLength(9)]
    [Column("phone")]
    public string? Phone { get; set; }

    public IEnumerable<Carts> Carts {get; set;}

}