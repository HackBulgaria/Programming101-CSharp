# Problems to get you familiar with the most common language constructs

These problems will require using more specific language constructs.

## Number->List and List->Number

Implement the two functions:

* `List<int> NumberToList(int n)` which takes an integer and returns a list
of its digits
* `int ListToNumber(string digits)` which takes a list of digits and returns
the number from those digits

## Increasing and Decreasing Sequences

Implement the following functions:

* `bool IsIncreasing(int[] sequence)` which returns true if for every two
consecutive elements `a` and `b`, `a < b` holds.
* `bool IsDecreasing(int[] sequence)` which returns true if for every two
consecutive elements `a` and `b`, `a > b` holds.

## Extreme elements in a list

Implement the following functions:

* `int Min(int[] items)` - returns the mininum element in `items`
* `int Max(int[] items)` - returns the maximum element in `items`
* `int NthMin(int n, int[] items)` - returns the `n`th minimum element in
`items`
* `int NthMax(int n, int[] items)` - returns the `n`th maximum element in
`items`

## Reverse a String

Implement a function which takes a string and returns the same in
a reversed order.

`string ReverseMe(string original)`

## Reverse each word in a sentence

Implement a function which takes a string and returns a string
which has the same words but each word is in a reverse order.

`string ReverseEveryWord(string sentence)`

## Copy every character K times

`string CopyEveryChar(string input, int k)`

Example: `CopyEveryChar("tldr", 3) => "tttllldddrrr"`

## Decode an URL

Write a function which decodes a given URL following these rules:

%20=>' '
%3A=>':'
%3D=>'?'
%2F=>'/'

Input 'kitten%20pic.jpg'
Output 'kitten pic.jpg'

`string DecodeUrl(string input)`

## Is String A an anagram of String B?
`bool Anagram(string A, string B)`
See http://en.wikipedia.org/wiki/Anagram

No HashMaps, hashSets, or such stuff allowed : )

## Is an anagram of String A a SUBSEQUENCE in B?

Return whether an anagram of String A can be found in String B.

`bool HasAnagramOf(string A,string B)`