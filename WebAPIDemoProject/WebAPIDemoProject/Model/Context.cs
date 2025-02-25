using Microsoft.EntityFrameworkCore;

namespace WebAPIDemoProject.Model
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server = localhost;" +
                "Database = ETrade; " +"Username=postgres;"+"Password=test123;"
                
                );
        }

        public DbSet<Product> Products {get; set;}
        public DbSet<Basket> Baskets{ get; set; }
    }
}
