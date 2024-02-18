using DeltaCore.Models;

namespace DeltaCore.Repository.Interface
{
    public interface Iproduct
    {
        Task<IEnumerable<Product>> GetAllProducts();
    }
}
