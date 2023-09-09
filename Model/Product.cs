using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderApp.Model
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public double DiscountPercentage { get; set; }

        public Product(int id, string name, double price, double discountPercentage)
        {
            ProductId = id;
            ProductName = name;
            ProductPrice = price;
            DiscountPercentage = discountPercentage;
        }

        public double CalculateDiscountedPrice()
        {
            //Price after discount = Original Price - (Original price × Discount %)
            var discountedPrice = ProductPrice-(ProductPrice*(DiscountPercentage/100));
            return discountedPrice;
        }

        
        
    }
}
