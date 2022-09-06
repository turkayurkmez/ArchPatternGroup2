namespace shop.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public List<string> Features { get; set; }
        public int StockCount { get; set; }
        public bool IsAvailable { get; set; }


    }
}