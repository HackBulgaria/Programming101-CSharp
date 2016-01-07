using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventory
{
    public class VatTaxCalculator
    {
        private List<CountryVatTax> taxes;
        private CountryVatTax defaultTax;

        public VatTaxCalculator(IList<CountryVatTax> taxes)
        {
            this.taxes = new List<CountryVatTax>(taxes);

            //shorter version using LINQ:
            //defaultTax = this.taxes.FirstOrDefault(t => t.IsDefault);
            foreach(var t in this.taxes)
            {
                if(t.IsDefault)
                {
                    defaultTax = t;
                    break;
                }
            }

            if(defaultTax == null)
            {
                throw new ArgumentException("No default tax");
            }
        }

        public double CalculateTax(string countryId, double productPrice)
        {
            //shorter version using LINQ:
            //var tax = taxes.FirstOrDefault(t => t.CountryId == countryId);
            CountryVatTax tax = null;
            foreach (var t in taxes)
            {
                if (t.CountryId == countryId)
                {
                    tax = t;
                    break;
                }
            }

            if (tax != null)
            {
                return CalculateTax(tax, productPrice);
            }
            else
            {
                throw new NotSupportedCountryException(countryId);
            }
        }

        public double CalculateTax(double productPrice)
        {
            return CalculateTax(defaultTax, productPrice);
        }

        private double CalculateTax(CountryVatTax tax, double productPrice)
        {
            return tax.VatTax * productPrice;
        }
    }
}
