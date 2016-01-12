# Static Classes and Methods

## Implement static class ArrayExtension

- Write a static method Intersect which takes as arguments two lists and implements an intersection over lists

`List<T> Intersect(List<T> firstList, List<T> secondList)`

- Write a static method UnionAll which takes as arguments two lists and implements an union between over them (including duplicating items)

`List<T> UnionAll(List<T> firstList, List<T> secondList)`

- Write a static method Union which takes as arguments two lists and implements an union between over them (without duplicating items)

`List<T> Union(List<T> firstList, List<T> secondList)`

- Write a static method Join which takes as argument a list of string values.
It should join all string values with a specific character which is predifined in another class.
The character must be kept in a private static member :

`string Join(List<string> list)`

`private static readonly char ReplacingValue;`

- The replacing character must be loaded from class Configuration which has the following method:

`public char GetReplacingValue();`

The method GetReplacingValue should use current date and time in order to calculate the replacing character.
- Current time :  19.06.2015 17:35:50
- Step 1 : 19.06.2015 17:35:50 => 1 + 9 + 0 + 6 + 2 + 0 + 1 + 5 + 1 + 7 + 3 + 5 + 5 + 0= 48 // sum all digits
- Step 2 : 48 % 25 = 23 // calculate number mod 25
- Step 3 : 65 + 23 // adds 65 to the number
- Step 3 : Get the corresponding unicode character to the calculated number : 88 => return 'X'

- Convert method Intersect to extension method

**Note the type T must implement IComparable

# Anonymous Types and Nested classes

## Sorting Books and Magazines

Create two classes 
- Book with properties Name (string), Id (int).
- Magazine with properties Title(string), ISBN (int)
- Create a static class MagazineAndBookSorter which contains a public static method called Sort

`public static List<string> Sort(List<Book> books, List<Magazine> magazines)`

It should sort all magazines and books based on Name/Title and Id/ISBN.
This method should  merge both collection into a single list of string containing the Name/Title.
The list should be sorted according to Name/Title and then on Id/ISBN

- Use nested classed called Edition which should contain two properties EditionName(string) and Order(int) and which should be used for the sorting operation


# Partial Classes and Methods

## Implement partial class Employee

- Implement class Employee which has definition in two files:

`public partial class Employee`

- The first file should contain all properties including :

- FirstName (string)
- LastName (string)
- Salary (decimal)
- Position (string)
- Bonus (decimal)

and a definition of partial method Print() without implementation

The second file should contain all methods including :

- void Print() - partial method which should print first name together with last name
- CalculateAllIncome() => Salary + Bonus
- CalculateBalance() => Salary + Bonus - Taxes
