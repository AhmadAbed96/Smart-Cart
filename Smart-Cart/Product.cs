using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cart
{
    public enum ProductCategory
    {
        Food,
        Clothing,
        Electronics,
    }
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ProductCategory Category { get; set; }

        public Product( string name, decimal price, ProductCategory category ) 
        {
            this.Name = name;
            this.Price = price;
            this.Category = category;
        }
        public override string ToString()
        {
            return $"{Name} - {Category} - ${Price:F2}";
        }
    }
}
