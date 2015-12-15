# Sorting and searching algorithms

Today we'll add custom sorting and searching for arrays and Lists. For this purpose create a static class `SortAndSearchExtensions` where you'll create the extension methods.

## Bubble Sort

Create an extension method `BubbleSort()` that sorts the elements of an `IList<T>`. The method should accept an `IComparer<T>` parameter that will be used to compare the elements in the collection. It should sort the collection and return the same instance. The mtehod should be called like this:

```csharp
class MyIntComparer : IComparer<int>
{
  ...
}

int[] array = new int[]{2, 4, 1, 6, 10};
int[] sortedArray = (int[])array.BubbleSort(new MyIntComparer());
```

The method may also be called without an `IComparer<T>` parameter, in this case [Comparer\<T>.Default](https://msdn.microsoft.com/en-us/library/azhsac5f%28v=vs.110%29.aspx) should be used.

Read [here](https://en.wikipedia.org/wiki/Bubble_sort#Step-by-step_example) for information on bubble sort algorithm.

## Selection Sort

Just like bubble sort above, create an extension method `SelectionSort()` that implements the [selection sort algorithm](https://en.wikipedia.org/wiki/Selection_sort)

## Implementing IComparer

Make different implementations of `IComparer<T>` to demonstrate the sorting algorithms above:

* `LastDigitComparer` that compares integers by comparing only their last digit.
* `StringLengthComparer` that compares strings by their length. Strings with equal length are considered equal. Null strings are considered with 0 length.
* `OddEvenComparer` that compares nullable integers (`int?`) in the following way:
  * odd integers are greater than even integers
  * odd integers are sorted in increasing order
  * even integers are sorted in decreasing order
  * null values are always less than any other value
* `ReverseComparer<T>` that reverses the comparison of a given `IComparer<T>`.

## Bonus - Binary Search

Create an extension method `int BSearch()` that searches a sorted `IList<T>` collection using the [binary search algorithm](https://en.wikipedia.org/wiki/Binary_search_algorithm) and returns the index of the first match. If no matches are found the method should return -1. Again it should take an `IComparer<T>` parameter for comparing the elements.

```csharp
class MyIntComparer : IComparer<int>
{
  ...
}

MyIntComparer comparer = new MyIntComparer();

int[] array = new int[]{2, 4, 1, 6, 10};
int[] sortedArray = (int[])array.BubbleSort(comparer);

int index = sortedArray.BSearch(6, comparer);
```

The method may also be called without an `IComparer<T>` parameter, in this case [Comparer\<T>.Default](https://msdn.microsoft.com/en-us/library/azhsac5f%28v=vs.110%29.aspx) should be used.

## Bonus - Quicksort and Merge sort

The bubble sort and selection sort algorithms are very inefficient. Much better sorting algorithms are [Quicksort](https://en.wikipedia.org/wiki/Quicksort) and [Merge sort](https://en.wikipedia.org/wiki/Merge_sort). Try to implement them as well.
