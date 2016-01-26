# Introduction to SQL

## Data Definition Language

We will create a database for the `Hack Company` to store information about its employees, products and customers. For that purpose create a new database `HackCompany`. **For the following exercises don't use the shortcuts in SQL Management Studio but try to write the scripts manually yourself!** Create the appropriate tables and relationships between them. Don't forget to create a key column and a primary key for each table!

It is a good idea to save the `.sql` scripts and save them in your repository.

### Departments and employees

The company has several departments a hierarchy of employees:
* Each department has:
  * Name
* Each employee has:
  * Name
  * Email - optional
  * Date of birth
  * Manager - another employee that is his/her manager. The big boss doesn't have a manager.
  * Department - the department the employee works in

### Products
The company creates products with different categories:
* Each category has:
  * Unique 3 letter code
  * Name
* Each product has:
  * Name
  * Single price
  * Category

### Customers
The company keeps track of its customers:
* Each customer has:
  * Name
  * Email - optional
  * Address
  * Discount - a percent discount applied to everything the customer buys; optional

### Orders
The company keeps track of all orders:
Each order has:
* Date and time of the order
* Customer
* Total Price
* Each order may contain several products with different quantities - implement it as a many-to-many relationship.
