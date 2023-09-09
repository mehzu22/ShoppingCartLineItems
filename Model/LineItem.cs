using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderApp.Model
{
    internal class LineItem
    {
        public int LineItemId { get; set; }
        public int Quantity { get; set; }

        Product products;//singular name

        public LineItem(int lineItemId,int quantity,Product product)
        {
            LineItemId = lineItemId;
            Quantity = quantity;
            products = product;
            
        }
        public double CalculateLineItemCost()
        {
            double discountPrice = products.CalculateDiscountedPrice();
            var lineItemCost = discountPrice * Quantity;
            return lineItemCost;
        }

        public override string ToString()
        {
            return $"LineItemId\tProductId\tProductName\tQuantity\tUnitPrice\tDiscount%\tUnitCostAfetrDiscount\tTotalLineItemCost\n" +
                $"{LineItemId}\t\t{products.ProductId}\t\t{products.ProductName}\t\t{Quantity}\t\t{products.ProductPrice}\t\t{products.DiscountPercentage}" +
                $"\t\t{products.CalculateDiscountedPrice()}\t\t\t{CalculateLineItemCost()}";
        }
    }
}
