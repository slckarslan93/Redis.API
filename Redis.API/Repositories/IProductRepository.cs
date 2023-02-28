using Redis.API.Models;

namespace Redis.API.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAsync();

        Task<Product> GetByIdAsync(int Id);

        Task<Product> CreateAsync(Product product);
    }
}