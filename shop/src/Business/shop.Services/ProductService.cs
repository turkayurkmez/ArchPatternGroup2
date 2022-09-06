using shop.DataAccess;
using shop.Entities;
using shop.Services.DTOs.Responses;

namespace shop.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository repository;

        public ProductService(IProductRepository repository)
        {
            this.repository = repository;
        }

        public List<ProductListResponse> GetProducts()
        {
           
            var products = repository.GetAll();
            var dtos = products.Select(p => new ProductListResponse { Id = p.Id, ImageUrl = p.ImageUrl, Name = p.Name, Price = p.Price }).ToList();
            return dtos;
        }
    }
}