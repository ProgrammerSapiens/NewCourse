using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Monday
{
    internal class OrderRepository : IOrderRepository
    {
        private List<Order> orders;

        public OrderRepository()
        {
            orders = new List<Order>();
        }

        public void AddOrder(Order order)
        {
            int id = orders.FindIndex(x => x.OrderId == order.OrderId);

            if (id == -1)
            {
                orders.Add(order);
            }
            else Console.WriteLine("Such ID already exists");
        }

        public List<Order> GetAllOrders()
        {
            return orders;
        }

        public Order GetOrderById(int orderId)
        {
            int id = orders.FindIndex(x => x.OrderId == orderId);

            if (id == -1)
            {
                return null;
            }

            return orders[id];
        }

        public void RemoveOrder(int orderId)
        {
            int id = orders.FindIndex(x => x.OrderId == orderId);

            if (id != -1)
            {
                orders.RemoveAt(id);
                Console.WriteLine("The element was removed successfully");
            }
            else Console.WriteLine("The element was not found");
        }
    }
}
