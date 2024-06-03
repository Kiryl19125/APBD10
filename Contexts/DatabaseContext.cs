using APBD10.Models;
using Microsoft.EntityFrameworkCore;

namespace APBD10.Contexts;

public class DatabaseContext : DbContext
{
   public DbSet<Products> Products { get; set; }
    public DbSet<Roles> Roles { get; set; }
    public DbSet<Accounts> Accounts { get; set; }
    public DbSet<Carts> Carts { get; set; }
    public DbSet<Categories> Categories { get; set; }
    public DbSet<ProductsCategories> ProductsCategories { get; set; }
    
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Roles>().HasData(new List<Roles>
            {
                new Roles()
                {
                    IdRole = 1,
                    Name = "Someone"
                }
            }
        );
        
        modelBuilder.Entity<Accounts>().HasData(new List<Accounts>
            {
                new Accounts()
                {
                    IdAccount = 1,
                    IdRole = 1,
                    FirstName = "Max",
                    SecondName = "Valko",
                    Email = "msadsa@gmail.com",
                    Phone = "09696262",
                }
            }
        );
        
        modelBuilder.Entity<Products>().HasData(new List<Products>
            {
                new Products()
                {
                   PkProducts = 1,
                   Name = "Milk",
                   Weight = (decimal) 2.1,
                   Width = (decimal) 2.3,
                   Height = (decimal) 3.1,
                   Depth = (decimal) 2.7
                }
            }
        );
        
        modelBuilder.Entity<Carts>().HasData(new List<Carts>
            {
                new Carts()
                {
                    IdAccount = 1,
                    IdProduct = 1,
                    Amount = 200
                }
            }
        );
        
        modelBuilder.Entity<Categories>().HasData(new List<Categories>
            {
                new Categories()
                {
                    IdCategories = 1,
                    Name = "Category 1"
                }
            }
        );
        
        modelBuilder.Entity<ProductsCategories>().HasData(new List<ProductsCategories>
            {
                new ProductsCategories()
                {
                    IdProduct = 1,
                    IdCategory = 1
                }
            }
        );
    } 
}