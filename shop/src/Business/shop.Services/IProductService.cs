using shop.Entities;
using shop.Services.DTOs.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Services
{
    public interface IProductService
    {
        List<ProductListResponse> GetProducts();
    }
}
