using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurdleTask
{
    public class Sales
    {
        private List<Thing> _orders;

        public Sales()
        {
            _orders = new List<Thing>();
        }

        public void Add(Thing order)
        {
            _orders.Add(order);
        }

        public void PrintOrders()
        {
            Console.WriteLine("Sales:");
            foreach (var order in _orders)
            {
                order.Print();
            }
        }
    }
}
