using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoading
{
    class Program
    {
        private static Customer customer = null;
        static void Main(string[] args)
        {
            Customer o = new Customer(); // order object not loadedxzzzffxx
            Console.WriteLine(o.CustomerName);
            
            foreach (Order o1 in o.Orders) // Load order object only at this moment
            {
                Console.WriteLine(o1.OrderNumber);
            }
        }
    }
}
