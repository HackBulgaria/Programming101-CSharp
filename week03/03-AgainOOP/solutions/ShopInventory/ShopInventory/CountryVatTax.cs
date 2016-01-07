using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventory
{
    public class CountryVatTax
    {
        public string CountryId { get; private set; }
        public double VatTax { get; private set; }
        public bool IsDefault { get; private set; }

        public CountryVatTax(string countryId, double vatTax, bool isDefault)
        {
            CountryId = countryId;
            VatTax = vatTax;
            IsDefault = isDefault;
        }
    }
}
