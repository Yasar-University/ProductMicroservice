using Microsoft.EntityFrameworkCore;
using ProductMicroservice.Model;

namespace ProductMicroservice.DBContexts
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    id = 1,
                    name = "Electronics",
                },
                new Category
                {
                    id = 2,
                    name = "Clothes",
                },
                new Category
                {
                    id = 3,
                    name = "Grocery",
                }
            );
        }

    }
}