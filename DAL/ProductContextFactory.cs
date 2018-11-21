using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DAL
{
    public class ProductContextFactory : IDesignTimeDbContextFactory<ProductsDbContext>
    {
        public ProductContextFactory(){}

        public ProductsDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ProductsDbContext>();
            
            var connection = "Server=localhost;User Id=root;Password=root;Database=products;port=3306";
           
            optionsBuilder.UseMySql(connection);

            return new ProductsDbContext(optionsBuilder.Options);
        }
    }
}