using JoviRestaurant.Web.Models;

namespace JoviRestaurant.Web.Services.IServices
{
    public interface IProductService : IBaseService
    {
        Task<T> GetAllProductsAsync<T>();
        Task<T> GetProductByIdAsync<T>(int id);
        Task<T> CreateProductAsync<T>(ProductDTO productDto);
        Task<T> UpdateProductAsync<T>(ProductDTO productDto);
        Task<T> DeleteProductAsync<T>(int id);
    }
}