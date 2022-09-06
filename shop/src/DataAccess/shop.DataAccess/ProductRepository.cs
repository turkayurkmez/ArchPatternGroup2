using shop.Entities;

namespace shop.DataAccess
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetAll()
        {
            return new List<Product>
            {
                new Product{ Id=1, Name="Akıllı aydınlatma", Price=260},
                new Product{ Id=2, Name="Bluetooth saat", Price=2000}

            };
        }

        public void SearchByName()
        {
            throw new NotImplementedException();
        }
    }
}