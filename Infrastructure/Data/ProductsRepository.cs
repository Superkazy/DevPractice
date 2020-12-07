using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;

namespace Infrastructure.Data
{
    public class ProductsRepository : IProductRepository
    {
        public Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Product> GetProductsByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}