using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    static class DataAccess
    {
        static NORTHWNDEntities context = new NORTHWNDEntities();

        public static NORTHWNDEntities Context { get { return context; } }

        public static void SaveChanges()
        {
            context.SaveChanges();
        }

        public static List<Employee> GetEmployeesWithNonNullCountry()
        {
            return
                context.Employees.
                Where(x => !String.IsNullOrEmpty(x.Country)).ToList();
        }

        public static List<Product> GetProductsForOrder(int orderId)
        {
            var order = context.Orders.Where(x => x.OrderID == orderId).FirstOrDefault();
            if(order == null)
            {
                return new List<Product>();
            }

            return order.Order_Details.Select(x => x.Product).ToList();
        }
    }
}
