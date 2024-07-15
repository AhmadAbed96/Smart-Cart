using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cart
{
    public class ProductGenerator
    {
        public static Random random = new Random();
        public static string[] foodNames = { "Salmon", "Coffee", "Banana", "Tea", "Milk" };
        public static string[] clothingNames = { "T-Shirt", "Jeans", "Shoes", "Hat", "Jacket" };
        public static string[] electronicsNames = { "Phone", "Laptop", "Tablet", "Camera", "Headphones" };

        public static Product GenerateProduct()
        {
            ProductCategory category = (ProductCategory)random.Next(0, 3);
            string name = "";
            switch (category)
            {
                case ProductCategory.Food:
                    name = foodNames[random.Next(foodNames.Length)];
                    break;
                case ProductCategory.Clothing:
                    name = clothingNames[random.Next(clothingNames.Length)];
                    break;
                case ProductCategory.Electronics:
                    name = electronicsNames[random.Next(electronicsNames.Length)];
                    break;
            }
            decimal price = (decimal)(random.Next(100, 1000)) / 10;
            return new Product(name, price, category);
        }
    }
}
