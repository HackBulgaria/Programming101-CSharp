using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventory
{
    public class NotAvailableInInventoryException: ApplicationException
    {
        public int ProductId { get; private set; }
        public int ProductQuantity { get; private set; }

        public NotAvailableInInventoryException(int productId, int productQuantity):base(GetMessage(productId, productQuantity))
        {
            ProductId = productId;
            ProductQuantity = productQuantity;
        }

        private static string GetMessage(int productId, int productQuantity)
        {
            return string.Format("Product with id {0} and quantity {1} not available in inventory", productId, productQuantity);
        }
    }
}
