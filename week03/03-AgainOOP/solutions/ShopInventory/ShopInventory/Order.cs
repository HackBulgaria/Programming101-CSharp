using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventory
{
    public class Order
    {
        public IReadOnlyList<int> ProductIds { get; private set; }
        public IReadOnlyList<int> ProductQuantities { get; private set; }

        public Order(IList<int> productIds, IList<int> productQuantities)
        {
            if (productIds.Count == productQuantities.Count)
            {
                ProductIds = new List<int>(productIds);
                ProductQuantities = new List<int>(productQuantities);
            }
            else
            {
                throw new ArgumentException("The number of product ids and quantities do not match");
            }
        }
    }
}
