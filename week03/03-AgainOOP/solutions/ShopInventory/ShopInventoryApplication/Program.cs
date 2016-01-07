using ShopInventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventoryApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var inventory = GetInventory();

            Console.WriteLine(string.Format("Audit: {0}", inventory.Audit()));

            var order = new Order(
                new int[] { 1, 3, 5 },
                new int[] { 5, 7, 100 }
                );

            Console.WriteLine(string.Format("RequestOrder: {0}", inventory.RequestOrder(order)));

            Console.ReadKey();
        }

        private static ShopInventory.ShopInventory GetInventory()
        {
            var taxes = new CountryVatTax[]
            {
                new CountryVatTax("BG", 0.2, true),
                new CountryVatTax("GB", 0.3, false),
                new CountryVatTax("US", 0.4, false),
                new CountryVatTax("ISIS", 10, false),
                new CountryVatTax("ZAMUNDA", 0, false)
            };

            var calculator = new VatTaxCalculator(taxes);

            var products = new Product[]
            {
                new Product(1, "BG Apples", "BG", 2, 10, calculator),
                new Product(2, "BG Pears", "BG", 3, 15, calculator),
                new Product(3, "GB Apples", "GB", 5, 10, calculator),
                new Product(4, "ISIS Apples", "ISIS", 100, 10, calculator),
                new Product(5, "ZAMUNDA Apples", "ZAMUNDA", 0, 99999, calculator)
            };

            return new ShopInventory.ShopInventory(products);
        }
    }
}
