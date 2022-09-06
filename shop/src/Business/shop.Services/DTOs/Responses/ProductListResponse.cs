using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Services.DTOs.Responses
{
    public class ProductListResponse
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public int Id { get; set; }
        public decimal Price { get; set; }
    }
}
