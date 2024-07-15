using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cart
{
    public class GroceryStore
    {
        public List<Product> products;

        public GroceryStore()
        {
            products = new List<Product>();
            for (int i = 0; i < 10; i++)
            {
                Product product = ProductGenerator.GenerateProduct();
                if (product.Category == ProductCategory.Food)
                {
                    products.Add(product);
                }
            }
        }

        public void DisplayProducts()
        {
            
            Console.WriteLine("Available products in Grocery Store:");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }

        public Product GetProduct(string productName)
        {
            return products.Find(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));
        }
    }
}
