using DAL.Model;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class ProductsDbContext : DbContext
    {
        public virtual DbSet<ChildrenProducts> ChildrenProducts { get; set; }
        public virtual DbSet<Colors> Colors { get; set; }        
        public virtual DbSet<Egresos> Egresos { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Sizes> Sizes { get; set; }

        public ProductsDbContext(DbContextOptions<ProductsDbContext> options): base(options)
        { }
    }
}