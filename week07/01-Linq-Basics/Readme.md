# Anonymous Methods, Lambda Expressions, Linq

## Anonymous method

Rewrite AverageAggregator problem by using anonymous methods

## Lambda Expressions

Rewrite NotifyCollection problem by using lambda expressions

## LINQ

Create several classes :
class Product with the following properties:
Name : string,
ProductId : int,
CategoryId : int

class Order with the following properties:
OrderId : int,
Products : List<int>,
OrderDate : DateTime,
Name : string

class Category with the following properties :
CategoryId : int,
CategoryName : string

Implement following three methods :
* GetProducts() : returns a list with all products, ProductIds should be between 1 and 100
* GetCategories() : returns a list with all categories, CategoriesIds should be between 101 and 200
* GetOrders() : returns a list with all orders, OrderIds should be between 201 and 300

Write following queries
* Create linq query which returns all products with ids between 15 and 30
* Create linq query which returns all categories with ids between 105 and 125
* Create linq query which returns first 15 orders sorted by order name
* Create linq query which returns first 3 orders which contains a specific productId (e.g. 10).
Orders must be sorted based on OrderDate
The print order names.
* Create linq query which returns all product with the name of the category which they belong to.
Order the result based on CategoryName
The result must be printed to the console.
* Create linq query which returns all categories together with their products
Create class CategoryWithProduct which should keep the result
the class CategoryWithProduct must conrtain the following properties :
CategoryName : string,
ProductNames : List<string>,
CategoryId : int

