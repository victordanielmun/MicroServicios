

namespace Catalog.Services.Queries.DTOs
{
    public class ProductDto
    {
        public int ProductID { get; set; }
        public string Name { get; set;}

        public string Description { get; set; }

        public decimal Price { get; set; } = 0m;

        public ProductInStockDto Stock { get; set; }
        
    }
}
