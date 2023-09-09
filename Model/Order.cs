using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderApp.Model
{
    internal class Order
    {
        public int OrderId { get; set; }
        public DateTime date;
        public int OrderNo { get; set; }
        public List<LineItem> Items { get; set; }
        
        public Order(int oredrId,int orderNo,List<LineItem> items)
        {
            OrderId = oredrId;
            date = DateTime.Now;
            OrderNo = orderNo;
            Items = items;
        }
        public string GetLineItems()
        {
            string allLineItmes = "";
            foreach (LineItem lineItem in Items)
            {
                allLineItmes += lineItem.ToString()+"\n\n";
            }
            return allLineItmes;
        }

        public double CalculateOrderPrice()
        {
            double allLineItemCost=0;
            foreach (LineItem lineItem in Items)
            {
                allLineItemCost+=lineItem.CalculateLineItemCost();
            }
            return allLineItemCost;
        }
       
        public override string ToString()
        {
            return $"Order No : {OrderNo}\n" +
                $"Order Id : {OrderId}\n" +
                $"Order Date : {date}\n" +
                $"\nLineItems ----->\n\n{GetLineItems()}\n" +
                $"\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t---------------------\n" +
                $"\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t{CalculateOrderPrice()}\n";
        }



    }
}
