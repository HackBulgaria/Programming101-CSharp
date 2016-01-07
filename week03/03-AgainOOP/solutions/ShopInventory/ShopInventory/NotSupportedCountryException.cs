using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventory
{
    public class NotSupportedCountryException : ApplicationException
    {
        public string CountryId { get; private set; }

        public NotSupportedCountryException(string countryId):base(GetMessage(countryId))
        {
            CountryId = countryId;
        }

        private static string GetMessage(string countryId)
        {
            return string.Format("Country {0} not supported", countryId);
        }
    }
}
