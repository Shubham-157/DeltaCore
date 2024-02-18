using DeltaCore.Data;
using DeltaCore.Models;
using DeltaCore.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace DeltaCore.Repository.Service
{
    public class ProductService : Iproduct
    {
        private readonly ApplicationContext context;

        public ProductService(ApplicationContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            var data = await context.Products.ToListAsync();
            return data;
        }
    }
}
