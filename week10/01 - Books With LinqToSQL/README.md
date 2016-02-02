# Introduction to the task
Just as the Hello World is a rigth of passsage to programming, the book database is the right of passage to SQL Development.
The task for today is to create a pesronal book manager. It will be able to track your books, track the book loanage and help you organize.

In the real world clients will have requirements and you, as an awesome developer, will need to find out what your classes will need to be 
and what will the database schema look like. So it will be your task to design them.

# Entities

## Book
Of course at the center of our library will be a book.
It should atleast have the following properties:

* Title 
* Authors - One book can have more then one author.
* Description/Resume
* DatePublished
* Publisher - The name of the book publisher
* Genre - Could one book have more than one genre ?
* Pages
* ISBN

Do note that you may have more than one copy of a book. And yet you will want to knwo which copy is loaned to whom.

## Author

* First Name
* Last Name
* Year Born
* Year Died
* Books Written

## Users
Users cannot own books from the library. They can only loan books, as such you will most likely want their contact information:

* First Name
* Last Name
* Pseudonim
* Email
* Phone

# The application
The application will be a console application and will need to do the following tasks:

* Insert a new book

* Insert a new author

* Get all books contained in the library - sorted in alphabetical order by title.

* Get all books contained in the library sorted by author.

* Get all books sorted by gendre.

* Get all types of genders a given author has written. For instance:
 J. R. R. Tolkien has written: Fantasy, High fantasy, literacy criticism.
 
* Get all books written by a given author
Sergei Lukyanenko has written:
 1) Night Watch
 2) Day Watch

* Get the complete information(everything about the book and its authors) of a book by its ISBN

* Get the complete information Title(part of the title should also be accepted) - If there are more than one books with the same title get the fist one
If we search for information about: *Lord of the* we might get: 
*Lord of the Rings*, *Lord of the dance* or what ever else we have in the library.

* Loan a book to a user:
** You will want to keep track of the books you give to other people - to whom you have given WHAT book, when you have given it away and when do you expect it.
** you should mark when a book is returned.
** It will be up to you to think how to know which book has been given away, and wich is not.

