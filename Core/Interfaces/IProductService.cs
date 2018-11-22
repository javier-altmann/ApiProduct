using System.Collections.Generic;
using System.Threading.Tasks;
using Core.DTO;
using DAL.Model;

namespace Core.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ChildrenProducts>> GetAllAsync();
        Task<ChildrenProducts> GetAsync(int productId);
        Task CreateAsync(ChildrenProducts product);
        Task DeleteAsync(ChildrenProducts product);
        List<Test> List(); 
    }
}