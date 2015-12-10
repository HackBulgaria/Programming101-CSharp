
# Week04 - Generic Types - using the built-in generic collections

## Rewrite Pair class from the privous lessons (week 3) to support generic types

## Create generic Stack class
The following methods which must be implemented in Stack<T> class :
* Constructor()
* Peek() - Returns the object at the top of the Stack<T> without removing it
* Pop()	- Removes and returns the object at the top of the Stack<T>
* Push(T) - Inserts an object at the top of the Stack<T>
* Clear()	- Removes all objects from the Stack<T>
* Contains(T) Determines whether an element is in the Stack<T>

## Create Dequeue class (double-ended queue) which must be based on List<T> or T[] array.
The following methods that must be implemented in Dequeue<T> class :

* Constructor()
* Clear()	- Removes all objects from the Dequeue<T>
* Contains(T) - Determines whether an element is in the Dequeue<T>	
* T RemoveFromFront() - Removes and returns an object at the beginning of the Dequeue<T>
* T RemoveFromEnd() - Removes and returns an object at the end of the Dequeue<T>
* AddToFront(T) - Adds an object to the beginning of the Dequeue<T>
* AddToEnd(T) - Adds an object to the end of the Dequeue<T>
* T PeekFromFront()	- Returns the object at the beginning of the Dequeue<T> without removing it.
* T PeekFromEnd()	- Returns the object at the end of the Dequeue<T> without removing it.


## Change previosly written Bill and BatchBill classes to support generic types

* Bill<T> class Value property should return T type

* BatchBill<T> class Total() method should return T type

* Add constraint to T type to be value type

## LottoGame class

* Create a LottoGame class
* Create an immutable class Combination{T, U} which accepts 6 values(int, bool, double, etc.).
* Override Equals and GetHashCode methods in order to check if two combinations are identical
* The group of first three values shares the same C# type (Valid for the second group of three values as well)
* Ask the user to enter any number of combinations he wants
* Validate if a combination is already entered
* Create an AddUserCombination method in LottoGame class which adds another user combination to the game (all the combinations must be stored internally in LottoGame class) 
* Create a private GetWinning combination method in TotoGame class which returns the secret winning combination
* Create a Validate method in LottoGame class which returns the result from the game. The method should return an object from LottoResult class. 
* LottoResult class must have two properties (IsWinning - bool and MatchedNumbersCount - byte)
* Print the result if a combination is winning - there is at least 1 matching value from the first group and second group or more than 1 matching value from the any of the groups

Combination example :
{1, 2, 3, "pesho", "gosho", "ivan"}, in the case the first three values are integers and the second three values are string



