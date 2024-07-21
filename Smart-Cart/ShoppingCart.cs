using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cart
{
    public class ShoppingCart
    {
        public List<Product> selectedItems = new List<Product>();

        public void AddItem(Product product)
        {

            selectedItems.Add(product);
            Console.WriteLine($"The {product.Name} has been added to the cart.");
        }



        public void RemoveItem(string productName)
        {
            Predicate<Product> match = selectedProduct => selectedProduct.Name == productName;
            Product product = selectedItems.Find(match);
            if (product != null)
            {
                selectedItems.Remove(product);
                Console.WriteLine($"{product.Name} has been removed from the cart.");
            }

            else
            {
                Console.WriteLine($"Product {productName} not found in the cart.");
            }
        }


        public void ViewItems()
        {
            if (selectedItems.Count == 0)
            {
                Console.WriteLine("Your cart is empty.");
            }
            else
            {
                Console.WriteLine("Items in your cart:");
                foreach (var item in selectedItems)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public decimal TotalCost()
        {
                    decimal totalCost = 0;
            for (int i = 0; i < selectedItems.Count; i++)
            {
                if (selectedItems.Count == 0)
                {
                    Console.WriteLine("The total cost is 0.00");
                }
                else
                {
                    foreach (var product in selectedItems)
                    {
                        totalCost += product.Price;
                    }
                }
                return totalCost;
            }
            return totalCost;
        }    

    }
}
