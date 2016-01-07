using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventory
{
    public class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string CountryId { get; private set; }
        public double SinglePrice { get; private set; }
        public int Quantity { get; private set; }

        public double SinglePriceWithTax { get; private set; }

        public Product(int id, string name, string countryId, double singlePrice, int quantity, VatTaxCalculator vatTaxCalculator)
        {
            Id = id;
            Name = name;
            CountryId = countryId;
            SinglePrice = singlePrice;
            Quantity = quantity;

            SinglePriceWithTax = SinglePrice + vatTaxCalculator.CalculateTax(CountryId, SinglePrice);
        }
    }
}
