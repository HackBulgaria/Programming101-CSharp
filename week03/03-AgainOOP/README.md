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
