## Queries
We will be using the Microsoft Adventure Works Database for this Exercies
http://msftdbprodsamples.codeplex.com/releases/view/55330

#Select statement exercises

Enter select statements to:
* Display the first name for everyone that's in the table.
* Display the first name, last name, and city for everyone that's not from Payson.
* Display all columns for everyone that is over 40 years old.
* Display the first and last names for everyone whose last name ends in an "ay".
* Display all columns for everyone whose first name equals "Mary".
* Display all columns for everyone whose first name contains "Mary".

#Update statement exercises

After each update, issue a select statement to verify your changes.
* Jonie Weber just got married to Bob Williams. She has requested that her last name be updated to Weber-Williams.
* Dirk Smith's birthday is today, add 1 to his age.
* All secretaries are now called "Administrative Assistant". Update all titles accordingly.
* Everyone that's making under 30000 are to receive a 3500 a year raise.
* Everyone that's making over 33500 are to receive a 4500 a year raise.
* All "Programmer II" titles are now promoted to "Programmer III".
* All "Programmer" titles are now promoted to "Programmer II".


#Some more selections:
* Show OrdeQty, the Name and the ListPrice of the order made by CustomerID 635
* Show all the addresses listed for 'Modular Cycle Systems'
* A "Single Item Order" is a customer order where only one item is ordered. Show the SalesOrderID and the UnitPrice for every Single Item Order.
* Where did the racing socks go? List the product name and the CompanyName for all Customers who ordered ProductModel 'Racing Socks'.
* Show the product description for culture 'fr' for product with ProductID 736
* Use the SubTotal value in SaleOrderHeader to list orders from the largest to the smallest. For each order show the CompanyName and the SubTotal and the total weight of the order.
* How many products in ProductCategory 'Cranksets' have been sold to an address in 'London'?
* For every customer with a 'Main Office' in Dallas show AddressLine1 of the 'Main Office' and AddressLine1 of the 'Shipping' address - if there is no shipping address leave it blank. Use one row per customer.
* For each order show the SalesOrderID and SubTotal calculated three ways:
A) From the SalesOrderHeader 
B) Sum of OrderQty*UnitPrice 
C) Sum of OrderQty*ListPrice
* Show the best selling item by value.
