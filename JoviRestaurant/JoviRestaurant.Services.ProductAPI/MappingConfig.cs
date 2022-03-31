using AutoMapper;
using JoviRestaurant.Services.ProductAPI.Models;
using JoviRestaurant.Services.ProductAPI.Models.Dto;

namespace JoviRestaurant.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDTO, Product>();
                config.CreateMap<Product, ProductDTO>();

            });
            return mappingConfig;
        }
    }
}
