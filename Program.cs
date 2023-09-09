using CustomerOrderApp.Model;

namespace CustomerOrderApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            List<Order> orders = new List<Order>
            {
                new Order(101, 1, new List<LineItem> { 
                    new LineItem(201, 2, new Product(1, "Biscuit", 100, 10)),
                    new LineItem(202, 3, new Product(2,"Chocolate",50,5))
                }),
                new Order(102, 2, new List<LineItem> { 
                    new LineItem(203, 4, new Product(3, "Soft Drink", 150, 10)), 
                    new LineItem(204, 2, new Product(4, "Bubble Gum", 250, 20)), 
                })
                //add more orders as needed
            };

            // create a Customer with the List of Orders
            Customer customer = new Customer(3001, "Mehzu", orders);
            Console.WriteLine(customer.ToString());
        }
    }
}