# VAT TAX calculator

You need to create a VAT tax calculator.
The calculator must calculate a product's price VAT tax based on a country.
The list with countries with the corresponding taxes must be passed to the calculator when it is initialized.
One of the countries must be the default country.
The calculator should return the additional tax on a specific product price based on its country.
If the country isn't specified then the default country must be used instead.

The following classes and method must be implemented:

* CountryVatTax class which contains the following properties : countryId, VATTax, IsDefault.
Note : the class must be immutable
* VAT tax calculator class that implementes a default contrustror which accept a list of CountryVatTax
* VAT tax calculator class must implements a method CalculateTax which should calculate VAT tax on a product price
* CalculateTax() method should accept product price and countryId (countryId isn't mandatory so an overload method should be implemented which doesn't accept countryId. In that case the default country tax must be used for calculations)
* If country isn't supported then an appropriate NotSupportedCountryException should be thrown.

# Shop Inventory

Create an ShopInventory class which contains all products available in an inventory.
*Every product must keep information about the product's price (before and after taxes), in which country the product could be bought(only one country) and the name of the product, product's quantity, product's id (integer). 
*The price with the taxes must be calculated with the help of the VAT Tax calculator. 
*The inventory must keep all available products (they should be passed to the constructor of the class). 
*The inventory should have a method called Audit which should tell the user how much money will be earned if all products are sold out
*Implement class order which contains information about a particular order (product's ids that must be bought + their quantity)
*The Inventory class must implements a method RequestOrder. It should get an order and calculates its amount. If the inventory doesn't contain all the required products then a specific exception must be thrown - NotAvailableInInventoryException. 
