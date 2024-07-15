namespace Smart_Cart
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();
            GroceryStore groceryStore = new GroceryStore();
            ClothingStore clothingStore = new ClothingStore();

            bool exit = false;
            while (!exit)
            {

                Console.WriteLine("\nWelcome to the Smart Shopping Cart");
                Console.WriteLine("1. Shop at Grocery Store");
                Console.WriteLine("2. Shop at Clothing Store");
                Console.WriteLine("3. View Shopping Cart");
                Console.WriteLine("4. Calculate Total Cost");
                Console.WriteLine("5. Remove Item from Cart");
                Console.WriteLine("6. Exit");
                Console.Write("Select an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        ShopAtStore(groceryStore, cart);
                        break;
                    case "2":
                        ShopAtStore(clothingStore, cart);
                        break;
                    case "3":
                        cart.ViewItems();
                        break;
                    case "4":
                        decimal totalCost = cart.TotalCost();
                        Console.WriteLine($"Total cost: ${totalCost:F2}");
                        break;
                    case "5":
                        RemoveItemFromCart(cart);
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }

        static void ShopAtStore(dynamic store, ShoppingCart cart)
        {
            store.DisplayProducts();
            Console.Write("Enter the name of the product to add to cart: ");
            string productName = Console.ReadLine();
            Product product = store.GetProduct(productName);
            if (product != null)
            {
                cart.AddItem(product);
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        static void RemoveItemFromCart(ShoppingCart cart)
        {
            cart.ViewItems();
            Console.Write("Enter the name of the product to remove from cart: ");
            string productName = Console.ReadLine();
            cart.RemoveItem(productName);
        }
    }
}
