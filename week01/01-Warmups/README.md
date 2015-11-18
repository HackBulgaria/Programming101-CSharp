# Warmup problems to get started in every language

This are the problems that you expect in every programming course.

## Factorial

In the given language, implement the factorial function `n!`.

* Implement it using a simple loop
* Implement it using recursion

## Lucas series

Because Fibonacci is way too trivial, implement the following functions that work with [Lucas series](https://en.wikipedia.org/wiki/Lucas_number):

* `NthLucas(n)` -> returns the nth Lucas number
* `FirstNLucas(n)` -> returns a list of the first `n` Lucas numbers

Quick hint:

```
L(0) = 2
L(1) = 1
L(n) = L(n-1) + L(n-2)
```

## Working with digits

Those are classic problems for using module division:

* Given an integer `n`, return the number of digits in `n` -> `CountDigits(n)`
* Given an integer `n`, return the sum of all digits in `n` -> `SumDigits(n)`
* `FactorialDigits(n)` -> for example, if we have `145`, we need to calculate `1! + 4! + 5!`

## Fibonacci number

Implement a function, called `FibNumber(n)`, which takes an integer n and returns a number, which is formed by concatenating the first n Fibonacci numbers.

Examples:

```
FibNumber(3) = 112
FibNumber(10) = 11235813213455
```

## Hack Numbers

A hack number is an integer, that matches the following criteria:

* The number, represented in binary, is a palindrome
* The number, represented in binary, has an odd number of 1's in it

Example of hack numbers:

* 1 is `1` in binary
* 7 is `111` in binary
* 7919 is `1111011101111` in binary

Implement the following functions:

* `IsHack(n)` -> checks if `n` is a hack number
* `NextHack(n)` -> returns the next hack number, that is bigger than `n`

Few examples:

```
IsHack(1) = True
NextHack(0) = 1

IsHack(21) = True
NextHack(10) = 21

IsHack(8191) = True
NextHack(8031) = 8191
```

## Vowels in a string

Implement a function, called `CountVowels(str)`, which returns the count of all vowels in the string `str`.

__Count uppercase vowels aswell!__

The English vowels are `aeiouy`.

**Examples:**

```
CountVowels("Python") = 2
CountVowels("Theistareykjarbunga") =  8
CountVowels("grrrrgh!") = 0
CountVowels("Github is the second best thing that happend to programmers, after the keyboard!") = 22
CountVowels("A nice day to code!") = 8
```

## Consonants in a string

Implement a function, called `CountConsonants(str)`, which returns the count of all consonants in the string `str`.

__Count uppercase consonants as well!__

The English consonants are `bcdfghjklmnpqrstvwxz`.

**Examples:**

```
CountConsonants("Python") = 4
CountConsonants("Theistareykjarbunga") = 11
CountConsonants("grrrrgh!") = 7
CountConsonants("Github is the second best thing that happend to programmers, after the keyboard!") = 44
CountConsonants("A nice day to code!") = 6
```

## Char Histogram

Implement a funcion, called `CharHistogram(string)`, which takes a string and returns a dictionary, where each key is a character from `string` and its value is the number of occurrences of that char in `string`.


```
CharHistogram("Python!") =
{ 'P': 1, 'y': 1, 't': 1, 'h': 1, 'o': 1, 'n': 1, '!': 1 }
CharHistogram("AAAAaaa!!!") 
 'A': 4, 'a': 3, '!": 3 }
```

## Palindrome Score

We denote the "Palindrome score" of an integer by the following function:

* `P(n) = 1`, if `n` is palindrome
* `P(n) = 1 + P(s)` where `s` is the sum of `n` and the `reverse of n`

Implement a function, called `PScore(n)`, which finds the palindrome score for n.

Lets see two examples:

* `PScore(121) = 1`, because `121` is a palindrome.
* `PScore(48) = 3`, because: 

1. `P(48) = 1 + P(48 + 84) = 132`
2. `P(132) = 1 + 1 + P(132 + 321 = 363)`
3. `P(363) = 1`.
4. When we return from the recursion, we get 3.

**Examples:**

```
PScore(121) = 1
PScore(48) = 3
PScore(198) = 6
```

## Integer palindomes

* Check if given integer `n` is palindrome -> `IsIntPalindrome(n)`
* Largets palindrome, smaller than given `N` -> `GetLargestPalindrome(N)`

For example, `1234321` is an integer palindrome.

## Prime numbers

The usual deal:

* Check if number is prime -> `IsPrime(n)`
* List the first `n` prime numbers -> `ListFirstPrimes(n)`
* List the first `n` prime numbers, using the [Sieve of Eratosthenes](https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes)

## Sum all numbers in a given string

You are given a string, where there can be numbers. Return the sum of all numbers in that string (not digits, numbers)

Examples:

```
SumOfNumbersInString("1111") = 1111
SumOfNumbersInString("1abc33xyz22") = 1 + 33 + 22 = 56
SumOfNumbersInString("abcd") = 0
```

## Anagrams

Here is the explanation of what an Anagram is - <http://en.wikipedia.org/wiki/Anagram>

* `IsAnagram(A, B)` - returns true, if the string `A` is an anagram of `B`
* `HasAnagramOf(A, B)` - returns true, if an anagram of string `A` can be found in `B`
