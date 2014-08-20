using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoading
{
    class Customer
    {
        private Lazy<List<Order>> _Orders = null; 
        private string _CustomerName = null;

        public Customer()
        {
            _CustomerName = "Shiv";
            _Orders = new Lazy<List<Order>>(() => LoadOrders()); // It will wait until asked for orders before actually loading
            
            //_Orders = LoadOrders(); // Loads the order object even though not needed
        }

        private List<Order> LoadOrders()
        {
            List<Order> temp = new List<Order>();
            Order o = new Order();
            o.OrderNumber = "ord1001";
            temp.Add(o);
            o = new Order();
            o.OrderNumber = "ord1002";
            temp.Add(o);
            return temp;
        }

        public string CustomerName
        {
            get
            {
                return _CustomerName;
            }
        }

        public List<Order> Orders
        {
            get
            {
                return _Orders.Value;
            }
        }
    }
}
