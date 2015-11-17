# Warmpup problems to get started in every language

This are the problems that you expect in every programming course.

## Factorial

In the given language, implement the factorial function `n!`.

* Implement it using a simple loop
* Implement it using recursion

## Lucas series

Because Fibonacci is way too trivial, implement the following functions that work with [Lucas series](https://en.wikipedia.org/wiki/Lucas_number):

* `nthLucas(n)` -> returns the nth Lucas number
* `firstNLucas(n)` -> returns a list of the first `n` Lucas numbers

Quick hint:

```
L(0) = 2
L(1) = 1
L(n) = L(n-1) + L(n-2)
```

## Working with digits

Those are classic problems for using module division:

* Given an integer `n`, return the number of digits in `n` -> `countDigits(n)`
* Given an integer `n`, return the sum of all digits in `n` -> `sumDigits(n)`
* `factorialDigits(n)` -> for example, if we have `145`, we need to calculate `1! + 4! + 5!`

## Fibonacci number

Implement a function, called `fibNumber(n)`, which takes an integer n and returns a number, which is formed by concatenating the first n Fibonacci numbers.

Examples:

```
fibNumber(3) = 112
fibNumber(10) = 11235813213455
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

* `isHack(n)` -> checks if `n` is a hack number
* `nextHack(n)` -> returns the next hack number, that is bigger than `n`

Few examples:

```
isHack(1) = True
nextHack(0) = 1

isHack(21) = True
nextHack(10) = 21

isHack(8191) = True
nextHack(8031) = 8191
```

## Vowels in a string

Implement a function, called `countVowels(str)`, which returns the count of all vowels in the string `str`.

__Count uppercase vowels aswell!__

The English vowels are `aeiouy`.

**Examples:**

```
countVowels("Python") = 2
countVowels("Theistareykjarbunga") =  8
countVowels("grrrrgh!") = 0
count_vowels("Github is the second best thing that happend to programmers, after the keyboard!") = 22
count_vowels("A nice day to code!") = 8
```

## Consonants in a string

Implement a function, called `countConsonants(str)`, which returns the count of all consonants in the string `str`.

__Count uppercase consonants as well!__

The English consonants are `bcdfghjklmnpqrstvwxz`.

**Examples:**

```
countConsonants("Python") = 4
countConsonants("Theistareykjarbunga") = 11
countConsonants("grrrrgh!") = 7
countConsonants("Github is the second best thing that happend to programmers, after the keyboard!") = 44
countConsonants("A nice day to code!") = 6
```

## Char Histogram

Implement a funcion, called `charHistogram(string)`, which takes a string and returns a dictionary, where each key is a character from `string` and its value is the number of occurrences of that char in `string`.


```
charHistogram("Python!") =
{ 'P': 1, 'y': 1, 't': 1, 'h': 1, 'o': 1, 'n': 1, '!': 1 }
charHistogram("AAAAaaa!!!") 
 'A': 4, 'a': 3, '!": 3 }
```

## Palindrome Score

We denote the "Palindrome score" of an integer by the following function:

* `P(n) = 1`, if `n` is palindrome
* `P(n) = 1 + P(s)` where `s` is the sum of `n` and the `reverse of n`

Implement a function, called `pScore(n)`, which finds the palindrome score for n.

Lets see two examples:

* `pScore(121) = 1`, because `121` is a palindrome.
* `pScore(48) = 3`, because: 

1. `P(48) = 1 + P(48 + 84) = 132`
2. `P(132) = 1 + 1 + P(132 + 321 = 363)`
3. `P(363) = 1`.
4. When we return from the recursion, we get 3.

**Examples:**

```
pScore(121) = 1
pScore(48) = 3
pScore(198) = 6
```

## Integer palindomes

* Check if given integer `n` is palindrome -> `isIntPalindrome(n)`
* Largets palindrome, smaller than given `N` -> `getLargestPalindrome(N)`

For example, `1234321` is an integer palindrome.

## Prime numbers

The usual deal:

* Check if number is prime -> `isPrime(n)`
* List the first `n` prime numbers -> `listFirstPrimes(n)`
* List the first `n` prime numbers, using the [Sieve of Eratosthenes](https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes)

## Sum all numbers in a given string

You are given a string, where there can be numbers. Return the sum of all numbers in that string (not digits, numbers)

Examples:

```
sumOfNumbersInString("1111") = 1111
sumOfNumbersInString("1abc33xyz22") = 1 + 33 + 22 = 56
sumOfNumbersInString("abcd") = 0
```

## Anagrams

Here is the explanation of what an Anagram is - <http://en.wikipedia.org/wiki/Anagram>

* `isAnagram(A, B)` - returns true, if the string `A` is an anagram of `B`
* `hasAnagramOf(A, B)` - returns true, if an anagram of string `A` can be found in `B`
