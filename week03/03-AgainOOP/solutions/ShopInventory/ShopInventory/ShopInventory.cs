using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventory
{
    public class ShopInventory
    {
        private List<Product> products;

        public ShopInventory(IList<Product> products)
        {
            this.products = new List<Product>(products);
        }

        public double Audit()
        {
            //shorter version using LINQ:
            //return products.Sum(p => p.SinglePriceWithTax * product.Quantity);

            double sum = 0;
            foreach(var product in products)
            {
                sum += product.SinglePriceWithTax * product.Quantity;
            }
            return sum;
        }

        public double RequestOrder(Order order)
        {
            double sum = 0;
            for(int i = 0; i < order.ProductIds.Count; i++)
            {
                bool success = false;

                //shorter version using LINQ:
                //var product = products.FirstOrDefault(p => p.Id == order.ProductIds[i]);
                Product product = null;
                foreach (var p in products)
                {
                    if (p.Id == order.ProductIds[i])
                    {
                        product = p;
                        break;
                    }
                }

                if(product != null && product.Quantity >= order.ProductQuantities[i])
                {
                    sum += product.SinglePriceWithTax * order.ProductQuantities[i];
                    success = true;
                }

                if(!success)
                {
                    throw new NotAvailableInInventoryException(order.ProductIds[i], order.ProductQuantities[i]);
                }
            }

            return sum;
        }
    }
}
