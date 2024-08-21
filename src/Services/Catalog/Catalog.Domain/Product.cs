

namespace Catalog.Domain
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set;}

        public string Description { get; set; }

        public decimal Price { get; set; } = 0m;

        public ProductInStock Stock { get; set; }
        
    }
}
