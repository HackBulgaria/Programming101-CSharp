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
TODO: do it
```

Notes:
* Don't forget to wrap your code with a `using` block to avoid leaving open connections to the database
* Connection strings (and any other application parameters) should't be hardcoded in the code. Use the [App.config](http://stackoverflow.com/a/13043569) instead:

```xml
TODO: do it
```

```csharp
TODO: do it
```

## Writing a command

Once we've established a connection to the database, we make queries by using a Command object ([SqlCommand](https://msdn.microsoft.com/en-us/library/system.data.sqlclient.sqlcommand%28v=vs.110%29.aspx)):

```csharp
TODO: do it
```

## Executing the command and retrieving data

There are several types of command execution we can use:

* [ExecuteNonQuery()](https://msdn.microsoft.com/en-us/library/system.data.sqlclient.sqlcommand.executenonquery(v=vs.110).aspx) - used for executing commands that don't return data. It only returns the numer of affected rows
```csharp
TODO: do it
```
* [ExecuteScalar()](https://msdn.microsoft.com/en-us/library/system.data.sqlclient.sqlcommand.executescalar(v=vs.110).aspx) - used for queries that return only 1 value
```csharp
TODO: do it
```
* [ExecuteReader()](https://msdn.microsoft.com/en-us/library/9kcbe65k(v=vs.110).aspx) - returns a data reader, which behaves like the readers that read from a file - it traverses the rows of the result sequentially one at a time
```csharp
TODO: do it
```
* [Using a DataAdapter](https://msdn.microsoft.com/en-us/library/system.data.sqlclient.sqldataadapter%28v=vs.110%29.aspx) - with a datadapter we can read the entire result set at once (unlike the DataReader) - sometimes it is useful but beware of large reult sets. In ths case we use it to populate [DataSets](https://msdn.microsoft.com/en-us/library/system.data.dataset%28v=vs.110%29.aspx) and [DataTables](https://msdn.microsoft.com/en-us/library/system.data.datatable%28v=vs.110%29.aspx) that store the information
```csharp
TODO: do it
```
