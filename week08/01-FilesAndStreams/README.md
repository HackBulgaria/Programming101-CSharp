# Files and Streams Problems

## File names histogram
Given a directory path, list all file names in it, together with the number of occurences of each file name. You should traverse all subdirectories recursively.

## Directory copy
Write a method that copies a directory and all of its content into a target directory. The method should accept a boolean flag that determines whether the copying should be done recursively.

## To upper

Write a program that reads a text file and changes all characters to upper case. It should save the result to another file.

## Simple file editor
Write a console application that manipulates a file. When started it should prompt the user for a text file to edit. The application should have the following commands:
* `list` - lists the contents of the file
* `clear` - clears the contents of the file
* `appendline` - appends a new line to the file
* `append <text>` - appends the text to the file
* `linecount` - outputs the numbers of lines in the file

## Fix these subtitles
Have you ever wanted to watch a movie, and all the cyrillic characters be like ������? 

Have you ever received emails like "Greetings, dear �������"?

These things happen because of different encoding and decoding schemes used.   

As we all know, even text files and strings are retained as binary in memory. 
So if we have the string 'Dumbledore', we need to store an array of bytes to represent it. 

The way we choose what bytes represent 'Dumbledore' in memory is called an **encoding scheme**. (a.k.a. encoding)
"windows-1251" is a type of encoding scheme.
"ISO-8859-1" is another type of encoding scheme.

The way we choose to convert it from a byte array to a char array is called a **decoding scheme**.

**Unicode** is an industry standard of encodings. There is no good reason against an Unicode encoding scheme.
UTF-8 is a good encoding scheme from the Unicode standard. (There are others, which differ slightly.)

So, here you are given a text file with a Windows-1251 encoding. Your task is to convert it to UTF-8. You can test this in your browser, just open the text file and choose to view it with UTF-8 encoding. (You might have to rename it to .html though)

The subtitle you need to fix are here: http://subsunacs.net/get.php?id=41854

In summary:
- Create a utility method `fixEncoding(Path path)`
- Backup the subtitles file so you don't have to download it again if you fail to write it.
- The text in the file given is encoded using a **windows-1251** scheme. 
- Conver it to UTF-8.

## Books and Authors

### Create classes
Create a class `Book` with properties `Title` (string) and `PublishDate` (DateTime).

Create a class `Author` with properties `Name` (string), `Email` (string), `Books` (a list of books).

Make the classes serializable.

Create an interface `IAuthorSerializer` with two methods for serializing and deserializing an object of type Author to a given file.

### Builtin serialization and deserialization
Implement `IAuthorSerializer` using the builtin .Net serialization functionality

### Custom serialization and deserialization
Implement `IAuthorSerializer` using custom serialization:
* On the first line write the name of the author
* On the second line write the author's email
* On each consecutive line write information about each book - the title and the publishing date delimited by `$`
