# Introduction to ADO.NET

ADO.NET is a library in .Net Framework for working with databases (and other data sources). It provides classes for opening a connection to a data source, creating a command (usually sql) to the data source, and retrieving the returned data.

## Data providers

ADO.NET offers data providers to connect to different types of data sources ([.NET Framework Data Providers](https://msdn.microsoft.com/en-us/library/a6cd7c08%28v=vs.110%29.aspx)). The most commonly used are:
* .NET Framework Data Provider for SQL Server - used for working with Microsoft SQL Server (that we'll be using)
* .NET Framework Data Provider for Oracle - used for working with Oracle databases
* .NET Framework Data Provider for ODBC - ODBC is a standard for connecting to SQL data sources. With that provider you can connect to MS SQL Server, Oracle, even an excel file etc.
