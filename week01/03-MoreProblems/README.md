# More problems to get you familiar with Visual Studio debugger.

Some more small tasks plus some image manipulation problems.

## Grayscale Image

Make a program which loads a bitmap into memory, converts it to
a grayscale image and then saves it to a file.

`void GreyScaleImage(Bitmap bitmap, string savePath)`

[What is Grayscale](https://en.wikipedia.org/wiki/Grayscale#Converting_color_to_grayscale)

Basically, you can use any linear combination of the color components:

Gray = x.Red + y.Green + z.Blue, where x+y+z are floating point numbers which sum to 1.

## Interpolate image (nearest neighbour)

Make a program which loads a bitmap into memory, then rescales it
into a new bitmap using the nearest neighbour interpolation.

`void ResampleImage(Bitmap bitmap, Size newSize, string savePath)`

## Apply a linear filter to an image

Make a program which loads a bitmap into memory, then applies a
linear filter and saves it into a new file.

You can use the [Box Blur Filter](https://en.wikipedia.org/wiki/Box_blur)

`void BlurImage(Bitmap bitmap, string savePath)`

## Maximal Scalar Product

Implement the following function: 

`int MaxScalarProduct(List<int> v1, List<int> v2)`.

You are given two vectors - `v1` and `v2`.
A scalar product of two vectors is the following:

```
v1 = {a1, a2, ..., an}
v2 = {b1, b2, ..., bn}

The scalar product is written as:
v1 . v2 = a1 * b1 + a2 * b2 + ... + an * bn
```

Find a permutation of `v1` and a permutation of `v2` for which their scalar
product **is the largest possible**

## Max Span

Implement the following function: `int MaxSpan(List<int> numbers)` 
where `numbers` is a list of numbers.

Consider the leftmost and rightmost appearances of some value in the list.

We'll say that the "span" is the number of elements between the two inclusive.
A single value has a span of 1.

**Returns the largest span found in the given array.**

Examples:

```
MaxSpan({1, 2, 1, 1, 3}) = 4
MaxSpan({1, 4, 2, 1, 4, 1, 4}) = 6
MaxSpan({1, 4, 2, 1, 4, 4, 4}) = 6
```

## Birthday Ranges

Implement a function `List<int> BirthdayRanges(List<int> birthdays, List<KeyValuePair<int, int>> ranges)`
We have a list `birthdays` and list of `ranges`.
`birthdays` - range from 0 to 365, 
`ranges` - one range is a pair of two numbers - `start` and `end`.

We want to calculate, for each range, how many people are born in it
(between `start` and `end` inclusive).

For example:

```
Birthdays - {5, 10, 6, 7, 3, 4, 5, 11, 21, 300, 15}
Ranges - {(4, 9), (6, 7), (200, 225), (300, 365)}
```

Will give the result:
```
{5, 2, 0, 1}
```

As we can see, between 4 and 9, inclusive, there are 5 people
with birthdays - 5, 6, 7, 4, 5.Between 300 and 365 there is exactly one
birthday - 300.

Test Examples:
```
>>> BirthdayRanges({1, 2, 3, 4, 5}, {(1, 2), (1, 3), (1, 4), (1, 5), (4, 6)})
{2, 3, 4, 5, 2}
```

## Matrix Bombing

You are given a `NxM` matrix of integer numbers.

We can drop a bomb at any place in the matrix, which has the following effect:

* All of the **3 to 8 neighbours** (depending on where you hit!) of the target
are reduced by the value of the target.
* Numbers can be reduced only to 0 - they cannot go to negative.

For example, if we have the following matrix:

```
10 10 10
10  9  10
10 10 10
```

and we drop bomb at `9`, this will result in the following matrix:

```
1 1 1
1 9 1
1 1 1
```

Implement a function called `int MatrixBombing(int[,] m)`.

The function should return the maximum damage we can inflict by bombing a
single cell. The damage in each cell is calculated as the difference
between the old value and value after bombing.

For example if we have the following matrix:

```
1 2  3  4
5 6  7  8
9 10 11 12
```

and run the function, we will have : `43` - the damage if we bomb at `7`

## Transversal

Lets have a set of sets:

`A = { {1, 2, 3} , {4, 5, 6}, {7, 8, 9} }`

A transversal `T` for `A` is a set that contains at least one element from each set of `A`.

For example: 
`T = {1, 4, 7}`

Implement a function `bool IsTransversal(List<int> transversal, List<List<int>> family)`,
which checks if given set is a valid `transerval` for another `family` of sets (set of sets).

Examples:
```
>>> IsTransversal({4, 5, 6}, {{5, 7, 9}, {1, 4, 3}, {2, 6}}))
true
>>> IsTransversal({1, 2}, {{1, 5}, {2, 3}, {4, 7}})
false
>>> IsTransversal({2, 3, 4}, {{1, 7}, {2, 3, 5}, {4, 8}})
false
```
