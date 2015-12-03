# The Cash Desk Problem

We are going to train our OOP skill by implementing a few classes, which will represent a cash desk.

The cash desk will do the following things:

* Take money as single bills
* Take money as batches (пачки!)
* Keep a total count
* Tell us some information about the bills it has

## Setup the Visual Studio solution

* Create an empty Visual Studio solution called **CashDeskProblem** (use the Blank Solution template - in Other Templates folder)
* Add a Class Library Project called **CashDesk** (won't have a Main method)
* Add a Console Application Project called **CashDeskApplication** (will have a Main method)
  * Add a reference to the **CashDesk** project - in the **CashDeskApplication** project:
    * Right click references->Add reference
    * In the Project References tab select the **CashDesk** project
    * Click OK
    * Now you can use the classes from **CashDesk** inside the **CashDeskApplication** project

## The Bill class

Inside the **CashDesk** library project create a class, called `Bill` which takes one parameter to its constructor - the `amount` of the bill - an integer.

The class should implement:

* ToString()
* Equals() and == operator
* Value - which should return the value of the bill
* Create and explicit cast to int, which should return the value of the bill

Here is an example usage:

```csharp

var a = new Bill(10);
var b = new Bill(5);
var c = new Bill(10);

Console.WriteLine((int)a) # 10
Console.WriteLine(a) # "A 10$ bill"

a == b // False
a == c // True

```


## The BatchBill class

We are going to implement a class, which represents more than one bill. A `BatchBill`!

Inside the **CashDesk** library project create a `BatchBill` class.

The class takes a list of `Bills` as the single constructor argument.

The class should have the following methods:

* `Count` - returns the number of `Bills` in the batch
* `Total()` - returns the total amount of all `Bills` in the batch
* `ToString()` - displays the number and total value of the bills

We should be able to iterate the `BatchBill` class with a for-loop.
Hint: See [IEnumerable](https://msdn.microsoft.com/en-us/library/system.collections.ienumerable%28v=vs.110%29.aspx) and [foreach](https://msdn.microsoft.com/en-us/library/ttw7t8t6.aspx)

Here is an example:

```csharp
var bills = new Bill[]{new Bill(10), new Bill(20), new Bill(50), new Bill(100)}
var batch = new BillBatch(bills);

foreach(var bill in batch)
{
  Console.WriteLine(bill);
}

// A 10$ bill
// A 20$ bill
// A 50$ bill
// A 100$ bill
```

## The CashDesk classs

Inside the **CashDesk** library project implement a `CashDesk` class, which has the following methods:

* `TakeMoney(money)`, where `money` can be either `Bill` or `BatchBill` class - adds money to the cash desk
* `Total()` - returns the total amount of money currenly in the desk
* `Inspect()` - prints a table representation of the money - for each bill, how many copies of it we have.

For example:

```csharp

var bills = new Bill[]{new Bill(10), new Bill(20), new Bill(50), new Bill(100), new Bill(100)}
var batch = new BillBatch(bills);

desk = new CashDesk();

desk.TakeMoney(new Bill(100));
desk.TakeMoney(batch);
desk.TakeMoney(new Bill(10));

Console.WriteLine(desk.total()) // 390
desk.Inspect();

// We have a total of 390$ in the desk
// We have the following count of bills, sorted in ascending order:
// 10$ bills - 2
// 20$ bills - 1
// 50$ bills - 1
// 100$ bills - 3

```

## The CashDesk application

Finally inside the **CashDeskApplication** project, create a console Cash Desk application that takes these commands from the user:

* takebill \<number> - adds a bill with value \<number> to the cashdesk
* takebatch \<number1> \<number2> ... - adds a batch of bills to the cashdesk
* total - prints the total money in the cash desk
* inspect - prints detailed information of the money in the cashdesk
* exit - exits the application

Hint: You can use a [while loop](http://stackoverflow.com/questions/18007246/user-input-commands-in-console-application/18007396#18007396)

For example:
```
takebill 10
takebatch 10 20 50 100 100
takebill 100
total //390
inspect

// We have a total of 390$ in the desk
// We have the following count of bills, sorted in ascending order:
// 10$ bills - 2
// 20$ bills - 1
// 50$ bills - 1
// 100$ bills - 3
```


# Bonus
## Coins
Add the ability to take coins -> figure for the coins to be compatible with the fills -> we will need batchCoins as well

## Valid money
We have created a mechanism for storing the bills and coins -> now we will want to take only valid money:

coins = [1,2,5,10,20,50,1]
bills = [2,5,10,20,50,100]

If we are offered money that we think is not valid - it is not contained in our lists of valid currency. We need to reject it.
The program must not stop! It should only display to the used that his money has been rejected.
* If the users offer a batch of money, it should reject all of the money.
* * Bonus: Make the program reject only the invalid money, and print which 

## Give change
A lot of people tend to save up coins. And most of the time they will and ask to gibe them bills for coins
Being good programmers, we will want to make things easy:
Make a method that takes a batch of coins and returns a batch of bills 
* Ofcourse we will have to update the inventory of money after this operation: 
* The change must occur in the most optimal way based on out inventory:
* * if we give 50,50,50, 20, 20, 20, 20, 10, 10 in coins we will have to return 2 bills and 50 coins 
* * the returned batch should never be  worse than the input

## Buy stuff
We have decided that our program is amazing! and will now want to sell it to all the shops in sofia.
So extend the user interface (and logic) to allow the user to sell items.
After choosing this option we will want to give the value of the product that we want to sell
Then we will input the money that was given to us
And our program will have to print one of the following:
* Not enough money
* Cannot give back change - if the give us more money that the product is worth
* The exact change we will have to return:
* * for instance "return 2 bills, 50 coins, 2 coins" AND NOT "2,52"
