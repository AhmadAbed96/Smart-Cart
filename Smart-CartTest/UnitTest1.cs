using System;
using System.Collections.Generic;
using Xunit;
using SmartShoppingCart;
using Smart_Cart;

namespace SmartShoppingCart.Tests
{
    public class ShoppingCartTests
    {
        [Fact]
        public void AddItem_ShouldIncreaseItemCount()
        {
            // Arrange
            ShoppingCart cart = new ShoppingCart();
            Product product = new Product("Apple", 1.00m, ProductCategory.Food);

            // Act
            cart.AddItem(product);

            // Assert
            Assert.Single(cart.selectedItems); // Assuming we have internal access or a way to get items
        }

        [Fact]
        public void RemoveItem_ShouldDecreaseItemCount()
        {
            // Arrange
            ShoppingCart cart = new ShoppingCart();
            Product product = new Product("Apple", 1.00m, ProductCategory.Food);
            cart.AddItem(product);

            // Act
            cart.RemoveItem("Apple");

            // Assert
            Assert.Empty(cart.selectedItems); // Assuming we have internal access or a way to get items
        }

        [Fact]
        public void RemoveItem_NotInCart_ShouldNotChangeItemCount()
        {
            // Arrange
            ShoppingCart cart = new ShoppingCart();
            Product product = new Product("Apple", 1.00m, ProductCategory.Food);
            cart.AddItem(product);

            // Act
            cart.RemoveItem("Banana");

            // Assert
            Assert.Single(cart.selectedItems); // Assuming we have internal access or a way to get items
        }

        [Fact]
        public void CalculateTotalCost_ShouldReturnCorrectSum()
        {
            // Arrange
            ShoppingCart cart = new ShoppingCart();
            Product product1 = new Product("Apple", 1.00m, ProductCategory.Food);
            Product product2 = new Product("Shirt", 1.00m, ProductCategory.Clothing);
            cart.AddItem(product1);
            cart.AddItem(product2);

            // Act
            decimal totalCost = cart.TotalCost();

            // Assert
            Assert.Equal(2.00m, totalCost);
        }
    }
}
