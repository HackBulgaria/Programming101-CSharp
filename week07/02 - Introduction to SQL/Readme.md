## Queries
We will be using the Microsoft Adventure Works Database for this Exercies
http://msftdbprodsamples.codeplex.com/releases/view/55330

#Select statement exercises

Enter select statements to:
1.Display the first name and age for everyone that's in the table.
2.Display the first name, last name, and city for everyone that's not from Payson.
3.Display all columns for everyone that is over 40 years old.
4.Display the first and last names for everyone whose last name ends in an "ay".
5.Display all columns for everyone whose first name equals "Mary".
6.Display all columns for everyone whose first name contains "Mary".

#Update statement exercises

After each update, issue a select statement to verify your changes.
1.Jonie Weber just got married to Bob Williams. She has requested that her last name be updated to Weber-Williams.
2.Dirk Smith's birthday is today, add 1 to his age.
3.All secretaries are now called "Administrative Assistant". Update all titles accordingly.
4.Everyone that's making under 30000 are to receive a 3500 a year raise.
5.Everyone that's making over 33500 are to receive a 4500 a year raise.
6.All "Programmer II" titles are now promoted to "Programmer III".
7.All "Programmer" titles are now promoted to "Programmer II".


Some more selections:
1. Show OrdeQty, the Name and the ListPrice of the order made by CustomerID 635
2. Show all the addresses listed for 'Modular Cycle Systems'
3. A "Single Item Order" is a customer order where only one item is ordered. Show the SalesOrderID and the UnitPrice for every Single Item Order.
4. Where did the racing socks go? List the product name and the CompanyName for all Customers who ordered ProductModel 'Racing Socks'.
5. Show the product description for culture 'fr' for product with ProductID 736
6. Use the SubTotal value in SaleOrderHeader to list orders from the largest to the smallest. For each order show the CompanyName and the SubTotal and the total weight of the order.
7. How many products in ProductCategory 'Cranksets' have been sold to an address in 'London'?
8. For every customer with a 'Main Office' in Dallas show AddressLine1 of the 'Main Office' and AddressLine1 of the 'Shipping' address - if there is no shipping address leave it blank. Use one row per customer.
9. For each order show the SalesOrderID and SubTotal calculated three ways:
A) From the SalesOrderHeader 
B) Sum of OrderQty*UnitPrice 
C) Sum of OrderQty*ListPrice
10. Show the best selling item by value.
