namespace ShopApp.Models
{
    public class ShhopingCard
    {
        public List<Product> Products { get; set; }

        public ShhopingCard()
        {
            Products = new List<Product>();
        }

        public decimal GetPrice()
        {
           return Products.Sum(x => x.Price);         
        }

        public void ClearCart()
        {
            Products.Clear();
        }

        public void ShowProducts(List<Product> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine($"[{product.Tag}]Produkt : {product.ProductName} Cena : {product.Price}");
            }
        }
    }
}
