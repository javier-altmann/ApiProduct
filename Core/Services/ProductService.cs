using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DTO;
using Core.Interfaces;
using DAL;
using DAL.Model;
using Microsoft.EntityFrameworkCore;

namespace Core.Services {
    public class ProductService : BaseService<ChildrenProducts>, IProductService {
        private ProductsDbContext context;

        public ProductService (ProductsDbContext repositoryContext) : base (repositoryContext) {
            this.context = RepositoryContext;
        }

        public async Task CreateAsync (ChildrenProducts product) {
            await CreateAsync (product);
            await context.SaveChangesAsync ();
            throw new System.NotImplementedException ();
        }

        public Task DeleteAsync (ChildrenProducts product) {
            throw new System.NotImplementedException ();
        }

        public async Task<ChildrenProducts> GetAsync (int productId) {
            var product = await FindByConditionAync (x => x.Id.Equals (productId));
            return null;
        }

        public async Task<IEnumerable<ChildrenProducts>> GetAllAsync () {
            var products = await context.ChildrenProducts.ToListAsync ();
            return products;
        }

        public List<Test> List () {
    
            var simple = context.ChildrenProducts.Select(y => new Simple{
                ColorCode  = y.Color.Code,
                SizeCode = y.Size.Code
            }).ToList();

            var testing = context.Products
                .Include (x => x.ChildrenProduct)
                .Select (x => new Test {
                    Code = x.Code,
                    Simple = simple
                }).ToList();
            return testing;
        }
    }

}