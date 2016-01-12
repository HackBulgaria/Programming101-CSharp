# Static Classes and Methods

## Implement static class ArrayExtension

- Write a static method Intersect which takes as arguments two lists and implements an intersection over lists

`List<T> Intersect(List<T> firstList, List<T> secondList)`

- Write a static method UnionAll which takes as arguments two lists and implements an union between over them (including duplicating items)

`List<T> UnionAll(List<T> firstList, List<T> secondList)`

- Write a static method Union which takes as arguments two lists and implements an union between over them

`List<T> UnionAll(List<T> firstList, List<T> secondList)`

- Write a static method Join which takes as argument a list of string values.
It should join all string values with a specific character which is predifined in another class.
The character must be kept in a private static member :

`private static readonly char ReplacingValue;`
`string Join(List<string> list)`

- The replacing character must be loaded from class Configuration which has the following method:

`public char GetReplacingValue();`

The method GetReplacingValue should use current time in order to calculate the replacing character.
Current time :  19.06.2015 17:35:50 
Step 1 : 19.06.2015 17:35:50 => 1 + 9 + 0 + 6 + 2 + 0 + 1 + 5 + 1 + 7 + 3 + 5 + 5 + 0 = 48 // sum all digits
Step 2 : 48 % 25 = 23 // calculate number mod 25
Step 3 : 65 + 23 // adds 65 to the number
Step 3 : Get the corresponding Ascii symbol to the calculated number 88 => return 'X'

- Convert method Intersect to extension method

