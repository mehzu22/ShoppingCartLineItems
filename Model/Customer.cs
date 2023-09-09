using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderApp.Model
{
    internal class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

        public List<Order> Orders { get; set; }

        public Customer(int customerId, string customnerName,List<Order> order)
        {
            CustomerId = customerId;
            CustomerName = customnerName;
            Orders = order;
        }

        public string GetAllOrdersList()
        {
            string ordresList = "";
            foreach (Order order in Orders)
            {
                ordresList += order.ToString()+"\n";
            }
            return ordresList;
        }

        public override string ToString()
        {
            return $"Customer ID : {CustomerId}\n" +
                $"Customer Name : {CustomerName}\n" +
                $"Oredr Count : {Orders.Count}\n\n" +
                $"Oredrs ----->\n\n{GetAllOrdersList()}";
        }
    }
}
