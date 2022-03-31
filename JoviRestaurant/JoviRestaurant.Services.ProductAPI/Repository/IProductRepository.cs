using JoviRestaurant.Services.ProductAPI.Models.Dto;

namespace JoviRestaurant.Services.ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDTO>> GetProducts();
        Task<ProductDTO> GetProductById(int id);
        Task<ProductDTO> CreateUpdateProduct(ProductDTO product);
        Task<bool> DeleteProduct(int productId);
    }
}
