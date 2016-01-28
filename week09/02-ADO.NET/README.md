# ADO.NET Problems

## Hack Company

We'll create a library that consumes the database from [last time](https://github.com/HackBulgaria/Programming101-CSharp/tree/master/week08/03-SQL-DatabaseDesign)

As usual create a library project for our library and a console application for interface. Put the connection string to the database in the App.config of the console application.

### DTO classes

Usually when communicating with an external service we use so called [DTO objects](https://en.wikipedia.org/wiki/Data_transfer_object). These are simple objects that only store the necessary information that is transferred to the service.

Create DTO objects for every table in the HackCompany database. For example, the employee will be:
```csharp
public class Employee
{
  public int Id {get; set}
  public string Name {get; set}
  public string Email {get; set}
  public DateTime BirthDate {get; set}
  public int? ManagerId {get; set}
  public int? DepartmentId {get; set}
}
```

### Communicating with the database

Create a utility class with methods for communicating with the database:
* For each database object create a method that accepts an appropriate DTO object and:
  * If a row with the same Id already exists update it
  * If a row with the same Id doesn't exist insert it. After that update the Id of the DTO object with the newly inserted Id (you can use the [@@IDENTITY](https://msdn.microsoft.com/en-us/library/ms187342.aspx) function to return the last inserted Id)
* For each database object create a method that accepts an Id and deletes the database row with that Id. It returns true/false indicating if the deletion was successful
* For each database object create a method that returns a list of DTO objects - all rows in the database
* For each database object create a method that accepts an Id and returns the appropriate DTO object with that Id. If there is no such Id in the database return null.

## Panda Social Network

Create a database for the [Panda Social Network](https://github.com/HackBulgaria/Programming101-CSharp/tree/master/week08/02-PandaSocialNetwork) with the appropriate tables in it.

After that in your solution in a separate project create a class `PandaSocialNetworkAdoNetStorageProvider` that loads and saves the Panda Network in the database. Use the above method with creating DTO classes first if needed.
