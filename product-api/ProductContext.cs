using Microsoft.EntityFrameworkCore;

namespace bootcamp_webapi
{
    public class ProductContext : DbContext, IProductContext
    {
        public ProductContext(DbContextOptions options) : base(options)
        {
        }

        protected ProductContext()
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var products = new[]
            {
                new {Id = 1L, Category = "Derivatives and Options", Inventory = 20, Name="Forwards"},
                new {Id = 2L, Category = "Contract", Inventory = 4, Name="Futures"},
                new {Id = 3L, Category = "Bond", Inventory = 2, Name="Government Bonds"},
                new {Id = 4L, Category = "Bond", Inventory = 50, Name="Corporate Bonds"},
                new {Id = 5L, Category = "High Net Worth", Inventory = 5, Name="Hedge Funds"}
            };

            modelBuilder.Entity<Product>().HasData(products);
        }
    }
}