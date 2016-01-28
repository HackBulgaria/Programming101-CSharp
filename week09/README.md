# Introduction to ADO.NET

ADO.NET is a library in .Net Framework for working with databases (and other data sources). It provides classes for opening a connection to a data source, creating a command (usually sql) to the data source, and retrieving the returned data.

## Data providers

ADO.NET offers data providers to connect to different types of data sources ([.NET Framework Data Providers](https://msdn.microsoft.com/en-us/library/a6cd7c08%28v=vs.110%29.aspx)). The most commonly used are:
* .NET Framework Data Provider for ODBC - ODBC is a standard for connecting to SQL data sources. With that provider you can connect to MS SQL Server, Oracle and many more, even an Excel file.
* .NET Framework Data Provider for SQL Server - a data provider used specifically with Microsoft SQL Server
* .NET Framework Data Provider for Oracle - a data provider used specifically with Oracle databases

## Connecting to the data source

We make a connection to the sql datasource using a special Connection object. Each data provider has its own connection class inheriting from [DbConnection](https://msdn.microsoft.com/en-us/library/system.data.common.dbconnection%28v=vs.110%29.aspx). We'll be using the SQL Server data provider which comes with the [SqlConnection](https://msdn.microsoft.com/en-us/library/system.data.sqlclient.sqlconnection%28v=vs.110%29.aspx) class

We pass a special connection string to the connection object, which is used to establish a connection to the data source:

```csharp
using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();
    
    // ...
}
```

Notes:
* Don't forget to wrap your code with a `using` block to avoid leaving open connections to the database
* Connection strings (and any other application parameters) should't be hardcoded in the code. Use the [App.config](http://stackoverflow.com/a/13043569) instead:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <startup> 
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.5.2" />
    </startup>
  <connectionStrings>
    <add name="AdventureWorks2012" connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=AdventureWorks2012;Integrated Security=True" providerName="System.Data.SqlClient"/>
  </connectionStrings>
  <appSettings>
    <add key="MyProgramParameter" value="tra-la-la"/>
  </appSettings>
</configuration>
```

```csharp
// first add a reference to System.Configuration

string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2012"].ConnectionString;
string parameter = ConfigurationManager.AppSettings["MyProgramParameter"];
```

## Writing a command

Once we've established a connection to the database, we make queries by using a Command object ([SqlCommand](https://msdn.microsoft.com/en-us/library/system.data.sqlclient.sqlcommand%28v=vs.110%29.aspx)):

```csharp
string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorks2012"].ConnectionString;

string query =
@"SELECT [BusinessEntityID]
      ,[PersonType]
      ,[Title]
      ,[FirstName]
      ,[MiddleName]
      ,[LastName]
FROM [Person].[Person]";

using (var connection = new SqlConnection(connectionString))
{
    connection.Open();

    var command = new SqlCommand(query, connection);

    //...
}
```

## Executing the command and retrieving data

There are several types of command execution we can use:

* [ExecuteNonQuery()](https://msdn.microsoft.com/en-us/library/system.data.sqlclient.sqlcommand.executenonquery(v=vs.110).aspx) - used for executing commands that don't return data. It only returns the numer of affected rows
```csharp
string query =
@"UPDATE Person.Person
SET Title = 'Mr.'
WHERE FirstName = 'Pesho'";

var command = new SqlCommand(query, connection);

int affectedRows = command.ExecuteNonQuery();
```
* [ExecuteScalar()](https://msdn.microsoft.com/en-us/library/system.data.sqlclient.sqlcommand.executescalar(v=vs.110).aspx) - used for queries that return only 1 value
```csharp
string query =
@"SELECT MAX(p.FirstName)
FROM Person.Person p";

var command = new SqlCommand(query, connection);

string lastPerson = (string)command.ExecuteScalar();
```
* [ExecuteReader()](https://msdn.microsoft.com/en-us/library/9kcbe65k(v=vs.110).aspx) - returns a data reader, which behaves like the readers that read from a file - it traverses the rows of the result sequentially one at a time
```csharp
private static string GetStringOrNull(object value)
{
    if(value is DBNull)
    {
        return null;
    }
    else
    {
        return (string)value;
    }
}

//...

string query =
@"SELECT TOP 100 [BusinessEntityID]
      ,[Title]
      ,[FirstName]
      ,[MiddleName]
      ,[LastName]
FROM [Person].[Person]";

using (var connection = new SqlConnection(connectionString))
{
    connection.Open();

    var command = new SqlCommand(query, connection);

    using (var reader = command.ExecuteReader())
    {
        while(reader.Read())
        {
            string title = GetStringOrNull(reader["Title"]);
            string first = GetStringOrNull(reader["FirstName"]);
            string middle = GetStringOrNull(reader["MiddleName"]);
            string last = GetStringOrNull(reader["LastName"]);

            string fullname = string.Format("{0} {1} {2} {3}", title, first, middle, last);
            Console.WriteLine(fullname);
        }
    }
}
```
* [Using a DataAdapter](https://msdn.microsoft.com/en-us/library/system.data.sqlclient.sqldataadapter%28v=vs.110%29.aspx) - with a datadapter we can read the entire result set at once (unlike the DataReader) - sometimes it is useful but beware of large reult sets. In ths case we use it to populate [DataSets](https://msdn.microsoft.com/en-us/library/system.data.dataset%28v=vs.110%29.aspx) and [DataTables](https://msdn.microsoft.com/en-us/library/system.data.datatable%28v=vs.110%29.aspx) that store the information
```csharp
private static string GetStringOrNull(object value)
{
    if(value is DBNull)
    {
        return null;
    }
    else
    {
        return (string)value;
    }
}

//...

string query =
@"SELECT TOP 100 [BusinessEntityID]
      ,[Title]
      ,[FirstName]
      ,[MiddleName]
      ,[LastName]
FROM [Person].[Person]";

DataTable table = new DataTable();
using (var connection = new SqlConnection(connectionString))
{
    connection.Open();

    var command = new SqlCommand(query, connection);

    var adapter = new SqlDataAdapter();
    adapter.SelectCommand = command;

    adapter.Fill(table);
}

foreach(DataRow row in table.Rows)
{
    string title = GetStringOrNull(row["Title"]);
    string first = GetStringOrNull(row["FirstName"]);
    string middle = GetStringOrNull(row["MiddleName"]);
    string last = GetStringOrNull(row["LastName"]);

    string fullname = string.Format("{0} {1} {2} {3}", title, first, middle, last);
    Console.WriteLine(fullname);
}
```

## Parameters

We can also pass parameters to queries. All parameters start with a `@` symbol. **Important: always use parameters instead of concatenating the query string to prevent SQL injection!**

```csharp
private static string GetStringOrNull(object value)
{
    if(value is DBNull)
    {
        return null;
    }
    else
    {
        return (string)value;
    }
}

//...

string query =
@"SELECT TOP 100 [BusinessEntityID]
      ,[Title]
      ,[FirstName]
      ,[MiddleName]
      ,[LastName]
FROM [Person].[Person]
WHERE FirstName = @FirstName";

using (var connection = new SqlConnection(connectionString))
{
    connection.Open();

    var command = new SqlCommand(query, connection);

    var firstNameParameter = new SqlParameter("@FirstName", SqlDbType.NVarChar, 50);
    firstNameParameter.Value = "Mary";
    command.Parameters.Add(firstNameParameter);

    using (var reader = command.ExecuteReader())
    {
        while (reader.Read())
        {
            string title = GetStringOrNull(reader["Title"]);
            string first = GetStringOrNull(reader["FirstName"]);
            string middle = GetStringOrNull(reader["MiddleName"]);
            string last = GetStringOrNull(reader["LastName"]);

            string fullname = string.Format("{0} {1} {2} {3}", title, first, middle, last);
            Console.WriteLine(fullname);
        }
    }
}
```
